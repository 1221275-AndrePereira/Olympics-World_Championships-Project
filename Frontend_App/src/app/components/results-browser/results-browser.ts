import { CommonModule } from '@angular/common';
import { Component, OnInit, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { debounceTime, distinctUntilChanged, Subject } from 'rxjs';
import {
  CountryMedal, EventOption, MedalTally, ResultRow, SortBy
} from '../../models/classification.model';
import { ResultsService } from '../../services/results.service';
import { flagUrlFor } from '../../../assets/flags';
import { SPORT_ICON } from '../../../assets/sportsIcons';
 
type View = 'results' | 'medalTable' | 'allTimeMedalTable' | 'countryMedalists' | 'allTimeCountryMedalists';
 
@Component({
  selector: 'app-results-browser',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './results-browser.html',
  styleUrl: './results-browser.css'
})
export class ResultsBrowserComponent implements OnInit {
  seasons = signal<string[]>([]);
  years = signal<number[]>([]);
  sports = signal<string[]>([]);
  events = signal<EventOption[]>([]);
 
  selectedSeason = '';
  selectedYear: number | null = null;
  selectedSport = '';
  selectedEventKey = '';
 
  athleteSearch = '';
  countrySearch = '';
  sortBy: SortBy = 'rank';
 
  view = signal<View>('results');
  drillCountry = signal<string | null>(null);
  drillFromAllTime = signal(false);
 
  resultRows = signal<ResultRow[]>([]);
  medalRows = signal<MedalTally[]>([]);
  countryMedalRows = signal<CountryMedal[]>([]);
 
  loading = signal(false);
  error = signal<string | null>(null);
 
  private searchInput$ = new Subject<void>();
 
  constructor(private api: ResultsService) {
    this.searchInput$.pipe(debounceTime(350), distinctUntilChanged()).subscribe(() => this.refresh());
  }
 
  ngOnInit(): void {
    this.api.getSeasons().subscribe({
      next: (seasons) => {
        this.seasons.set(seasons);
        if (seasons.length) {
          this.selectedSeason = seasons[0];
          this.onSeasonChange(true);
        }
      },
      error: () => this.error.set('Could not reach the API. Is the backend running on http://localhost:5005?')
    });
  }
 
  // --- cascading selects -------------------------------------------------
 
  onSeasonChange(initial = false): void {
    this.api.getYears(this.selectedSeason).subscribe((years) => {
      this.years.set(years);
      this.selectedYear = years[0] ?? null;
    });
    this.api.getSports(this.selectedSeason).subscribe((sports) => {
      this.sports.set(sports);
      this.selectedSport = sports[0] ?? '';
      this.onSportChange(initial);
    });
  }
 
  onSportChange(initial = false): void {
    if (!this.selectedSport) {
      this.events.set([]);
      this.selectedEventKey = '';
      return;
    }
    this.api.getEvents(this.selectedSeason, this.selectedSport).subscribe((events) => {
      this.events.set(events);
      this.selectedEventKey = events[0]?.key ?? '';
      if (initial) this.loadResults();
    });
  }
 
  onEventChange(): void {
    this.loadResults();
  }
 
  // --- actions -------------------------------------------------------------
 
  loadResults(): void {
    if (!this.selectedSeason || !this.selectedSport || !this.selectedEventKey) return;
    this.view.set('results');
    this.loading.set(true);
    this.error.set(null);
    this.api
      .getResults(this.selectedSeason, this.selectedSport, this.selectedEventKey, this.athleteSearch, this.countrySearch, this.sortBy)
      .subscribe({
        next: (rows) => { this.resultRows.set(rows); this.loading.set(false); },
        error: () => { this.error.set('Could not load results.'); this.loading.set(false); }
      });
  }
 
  showMedalTable(): void {
    if (!this.selectedSeason || this.selectedYear == null) return;
    this.view.set('medalTable');
    this.loading.set(true);
    this.error.set(null);
    this.api.getMedalTable(this.selectedSeason, this.selectedYear).subscribe({
      next: (rows) => { this.medalRows.set(rows); this.loading.set(false); },
      error: () => { this.error.set('Could not load the medal table.'); this.loading.set(false); }
    });
  }
 
  showAllTimeMedalTable(): void {
    if (!this.selectedSeason) return;
    this.view.set('allTimeMedalTable');
    this.loading.set(true);
    this.error.set(null);
    this.api.getAllTimeMedalTable(this.selectedSeason).subscribe({
      next: (rows) => { this.medalRows.set(rows); this.loading.set(false); },
      error: () => { this.error.set('Could not load the all-time medal table.'); this.loading.set(false); }
    });
  }
 
  drillIntoCountry(country: string): void {
    const fromAllTime = this.view() === 'allTimeMedalTable';
    this.drillFromAllTime.set(fromAllTime);
    this.drillCountry.set(country);
    this.loading.set(true);
    this.error.set(null);
 
    const request$ = fromAllTime
      ? this.api.getAllTimeCountryMedalists(this.selectedSeason, country, this.athleteSearch, this.sortBy)
      : this.api.getCountryMedalists(this.selectedSeason, this.selectedYear!, country, this.athleteSearch, this.sortBy);
 
    this.view.set(fromAllTime ? 'allTimeCountryMedalists' : 'countryMedalists');
 
    request$.subscribe({
      next: (rows) => { this.countryMedalRows.set(rows); this.loading.set(false); },
      error: () => { this.error.set('Could not load medalists for this country.'); this.loading.set(false); }
    });
  }
 
  backToMedalTable(): void {
    this.drillCountry.set(null);
    if (this.drillFromAllTime()) this.showAllTimeMedalTable();
    else this.showMedalTable();
  }
 
  // --- filters --------------------------------------------------------------
 
  onSearchChanged(): void {
    this.searchInput$.next();
  }
 
  onSortChanged(): void {
    this.refresh();
  }
 
  private refresh(): void {
    switch (this.view()) {
      case 'results': this.loadResults(); break;
      case 'countryMedalists':
      case 'allTimeCountryMedalists':
        if (this.drillCountry()) this.drillIntoCountry(this.drillCountry()!);
        break;
      // medal tables aren't filtered by athlete/country search in the original app
    }
  }
 
  // --- template helpers -------------------------------------------------
 
  flagUrl(country: string): string | null {
    return flagUrlFor(country);
  }
 
  sportIcon(sport: string): string | null {
    return SPORT_ICON[sport] ?? null;
  }
 
  medalEmoji(rank: number): string {
    if (rank === 1) return '\u{1F947}';
    if (rank === 2) return '\u{1F948}';
    if (rank === 3) return '\u{1F949}';
    return String(rank);
  }
}