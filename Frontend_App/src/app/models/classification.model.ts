export interface ClassificationEntry {
  id: number;
  sport: string;
  category: string;
  season: 'Summer' | 'Winter';
  country: string;
  event: string;
  entryName: string | null;
  classificationValue: number | null;
  isPending: boolean;
}
 
export interface PagedResult<T> {
  page: number;
  pageSize: number;
  totalItems: number;
  totalPages: number;
  items: T[];
}
 
export interface SportSummary {
  sport: string;
  season: 'Summer' | 'Winter';
  categories: string[];
}
 
export interface EntriesFilter {
  sport?: string;
  category?: string;
  country?: string;
  search?: string;
  pendingOnly?: boolean;
  page: number;
  pageSize: number;
}
 
// --- Results Browser -------------------------------------------------
 
export interface EventOption {
  key: string;
  label: string;
}
 
export interface ResultRow {
  rank: number;
  isPending: boolean;
  athlete: string;
  country: string;
}
 
export interface MedalTally {
  country: string;
  gold: number;
  silver: number;
  bronze: number;
  total: number;
}
 
export interface CountryMedal {
  year: number;
  sport: string;
  category: string;
  event: string;
  athlete: string;
  rank: number;
  country: string;
}
 
export type SortBy = 'rank' | 'athlete' | 'country';
export type ResultsView = 'results' | 'medalTable' | 'allTimeMedalTable' | 'countryMedalists' | 'allTimeCountryMedalists';