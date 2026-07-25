import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {
  ClassificationEntry,
  EntriesFilter,
  PagedResult,
  SportSummary
} from '../models/classification.model';
 

const API_BASE = 'http://localhost:5005/api';
 
@Injectable({ providedIn: 'root' })
export class ClassificationService {
  constructor(private http: HttpClient) {}
 
  getSports(): Observable<SportSummary[]> {
    return this.http.get<SportSummary[]>(`${API_BASE}/sports`);
  }
 
  getCountries(): Observable<string[]> {
    return this.http.get<string[]>(`${API_BASE}/entries/countries`);
  }
 
  getEntries(filter: EntriesFilter): Observable<PagedResult<ClassificationEntry>> {
    let params = new HttpParams()
      .set('page', filter.page)
      .set('pageSize', filter.pageSize);
 
    if (filter.sport) params = params.set('sport', filter.sport);
    if (filter.category) params = params.set('category', filter.category);
    if (filter.country) params = params.set('country', filter.country);
    if (filter.search) params = params.set('search', filter.search);
    if (filter.pendingOnly) params = params.set('pendingOnly', filter.pendingOnly);
 
    return this.http.get<PagedResult<ClassificationEntry>>(`${API_BASE}/entries`, { params });
  }
}