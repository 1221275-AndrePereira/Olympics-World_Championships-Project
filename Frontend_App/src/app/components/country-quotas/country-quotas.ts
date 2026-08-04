import { CommonModule } from '@angular/common';
import { Component, Input, OnChanges, signal } from '@angular/core';
import { CountriesService } from '../../services/countries.service';

@Component({
  selector: 'country-quotas',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './country-quotas.html',
  styleUrl: './country-quotas.css'
})
export class CountryQuotasComponent implements OnChanges {
  @Input() country: string | null = null;

  quotas = signal<{ sport: string; quotas: number }[]>([]);
  loading = signal(false);
  error = signal<string | null>(null);

  constructor(private api: CountriesService) {}

  ngOnChanges(): void {
    if (!this.country) return;
    this.load();
  }

  load(): void {
    if (!this.country) return;
    this.loading.set(true);
    this.error.set(null);
    this.api.getQuotasForCountry(this.country).subscribe({
      next: (q) => { this.quotas.set(q); this.loading.set(false); },
      error: () => { this.error.set('Could not load quotas for this country.'); this.loading.set(false); }
    });
  }
}
