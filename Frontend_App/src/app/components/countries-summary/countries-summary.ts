import { CommonModule } from '@angular/common';
import { Component, OnInit, signal } from '@angular/core';
import { CountriesService } from '../../services/countries.service';
import { flagUrlFor } from '../../../assets/flags';

@Component({
  selector: 'countries-summary',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './countries-summary.html',
  styleUrl: './countries-summary.css'
})
export class CountriesSummaryComponent implements OnInit {
  summaries = signal<any[]>([]);
  loading = signal(false);
  error = signal<string | null>(null);

  constructor(private api: CountriesService) {}

  ngOnInit(): void {
    this.loading.set(true);
    this.api.getSummaries().subscribe({ next: (s: any) => { this.summaries.set(s); this.loading.set(false); }, error: () => { this.error.set('Could not load country summaries.'); this.loading.set(false); } });
  }

  flagUrl(country: string): string | null { return flagUrlFor(country); }
}
