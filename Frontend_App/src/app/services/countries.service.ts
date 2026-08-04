import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

const API_BASE = 'http://localhost:5005/api';

export interface CountrySportQuota {
  sport: string;
  quotas: number;
}

@Injectable({ providedIn: 'root' })
export class CountriesService {
  constructor(private http: HttpClient) {}

  getSummaries() {
    return this.http.get(`${API_BASE}/countries/summary`);
  }

  getQuotasForCountry(country: string): Observable<CountrySportQuota[]> {
    return this.http.get<CountrySportQuota[]>(`${API_BASE}/countries/${encodeURIComponent(country)}/quotas`);
  }
}
