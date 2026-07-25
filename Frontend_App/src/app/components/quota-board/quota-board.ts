import { CommonModule } from '@angular/common';
import { Component, OnInit, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { debounceTime, distinctUntilChanged, Subject } from 'rxjs';
import { ClassificationEntry, PagedResult, SportSummary } from '../../models/classification.model';
import { ClassificationService } from '../../services/classification.service';
 
@Component({
  selector: 'quota-board',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './quota-board.html',
  styleUrl: './quota-board.css'
})
export class QuotaBoardComponent implements OnInit {
  sports = signal<SportSummary[]>([]);
  countries = signal<string[]>([]);
  result = signal<PagedResult<ClassificationEntry> | null>(null);
  loading = signal(false);
  error = signal<string | null>(null);
 
  // filter state
  selectedSport = '';
  selectedCategory = '';
  selectedCountry = '';
  searchText = '';
  pendingOnly = false;
  page = 1;
  pageSize = 25;
 
  private searchInput$ = new Subject<string>();
 
  constructor(private api: ClassificationService) {
    this.searchInput$.pipe(debounceTime(350), distinctUntilChanged()).subscribe(() => {
      this.page = 1;
      this.loadEntries();
    });
  }
 
  ngOnInit(): void {
    this.api.getSports().subscribe({
      next: (sports) => this.sports.set(sports),
      error: () => this.error.set('Could not load sports list from the API.')
    });
    this.api.getCountries().subscribe({
      next: (countries) => this.countries.set(countries)
    });
    this.loadEntries();
  }
 
  get categoriesForSelectedSport(): string[] {
    return this.sports().find((s) => s.sport === this.selectedSport)?.categories ?? [];
  }
 
  onSportChange(): void {
    this.selectedCategory = '';
    this.page = 1;
    this.loadEntries();
  }
 
  onFilterChange(): void {
    this.page = 1;
    this.loadEntries();
  }
 
  onSearchKeyup(value: string): void {
    this.searchInput$.next(value);
  }
 
  goToPage(p: number): void {
    const total = this.result()?.totalPages ?? 1;
    if (p < 1 || p > total) return;
    this.page = p;
    this.loadEntries();
  }
 
  clearFilters(): void {
    this.selectedSport = '';
    this.selectedCategory = '';
    this.selectedCountry = '';
    this.searchText = '';
    this.pendingOnly = false;
    this.page = 1;
    this.loadEntries();
  }
 
  loadEntries(): void {
    this.loading.set(true);
    this.error.set(null);
    this.api
      .getEntries({
        sport: this.selectedSport || undefined,
        category: this.selectedCategory || undefined,
        country: this.selectedCountry || undefined,
        search: this.searchText || undefined,
        pendingOnly: this.pendingOnly || undefined,
        page: this.page,
        pageSize: this.pageSize
      })
      .subscribe({
        next: (res) => {
          this.result.set(res);
          this.loading.set(false);
        },
        error: () => {
          this.error.set('Could not reach the API. Is the backend running on http://localhost:5005?');
          this.loading.set(false);
        }
      });
  }
}