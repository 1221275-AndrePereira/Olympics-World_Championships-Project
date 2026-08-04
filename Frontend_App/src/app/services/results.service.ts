import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CountryMedal, EventOption, MedalTally, ResultRow, SortBy } from '../models/classification.model';
 
const API_BASE = 'http://localhost:5005/api';
 
@Injectable({ providedIn: 'root' })
export class ResultsService {
  constructor(private http: HttpClient) {}
 
  getSeasons(): Observable<string[]> {
    return this.http.get<string[]>(`${API_BASE}/browse/seasons`);
  }
 
  getYears(season: string): Observable<number[]> {
    return this.http.get<number[]>(`${API_BASE}/browse/years`, { params: { season } });
  }
 
  getSports(season: string, year: number): Observable<string[]> {
    return this.http.get<string[]>(`${API_BASE}/browse/sports`, { params: { season, year } });
  }
 
  getEvents(season: string, year: number, sport: string): Observable<EventOption[]> {
    return this.http.get<EventOption[]>(`${API_BASE}/browse/events`, { params: { season, year, sport } });
  }
 
  getResults(
    season: string, year: number, sport: string, eventKey: string,
    athlete: string, country: string, sortBy: SortBy
  ): Observable<ResultRow[]> {
    let params = new HttpParams().set('season', season).set('year', year).set('sport', sport).set('eventKey', eventKey).set('sortBy', sortBy);
    if (athlete) params = params.set('athlete', athlete);
    if (country) params = params.set('country', country);
    return this.http.get<ResultRow[]>(`${API_BASE}/results`, { params });
  }
 
  getMedalTable(season: string, year: number): Observable<MedalTally[]> {
    const params = new HttpParams().set('season', season).set('year', year);
    return this.http.get<MedalTally[]>(`${API_BASE}/results/medal-table`, { params });
  }
 
  getAllTimeMedalTable(season: string): Observable<MedalTally[]> {
    const params = new HttpParams().set('season', season);
    return this.http.get<MedalTally[]>(`${API_BASE}/results/medal-table/all-time`, { params });
  }
 
  getCountryMedalists(
    season: string, year: number, country: string, athlete: string, yearSearch: string, sortBy: SortBy
  ): Observable<CountryMedal[]> {
    let params = new HttpParams().set('season', season).set('year', year).set('country', country).set('sortBy', sortBy);
    if (athlete) params = params.set('athlete', athlete);
    if (yearSearch) params = params.set('yearSearch', yearSearch);
    return this.http.get<CountryMedal[]>(`${API_BASE}/results/medalists`, { params });
  }
 
  getAllTimeCountryMedalists(
    season: string, country: string, athlete: string, yearSearch: string, sortBy: SortBy
  ): Observable<CountryMedal[]> {
    let params = new HttpParams().set('season', season).set('country', country).set('sortBy', sortBy);
    if (athlete) params = params.set('athlete', athlete);
    if (yearSearch) params = params.set('yearSearch', yearSearch);
    return this.http.get<CountryMedal[]>(`${API_BASE}/results/medalists/all-time`, { params });
  }
}