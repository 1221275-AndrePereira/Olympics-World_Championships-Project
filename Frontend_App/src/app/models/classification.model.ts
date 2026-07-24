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