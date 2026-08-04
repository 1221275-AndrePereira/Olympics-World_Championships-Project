import { Injectable, signal } from '@angular/core';
 
const STORAGE_KEY = 'olympics-theme';
 
@Injectable({ providedIn: 'root' })
export class ThemeService {
  theme = signal<'dark' | 'light'>(this.readInitialTheme());
 
  constructor() {
    this.apply(this.theme());
  }
 
  toggle(): void {
    const next = this.theme() === 'dark' ? 'light' : 'dark';
    this.theme.set(next);
    this.apply(next);
    localStorage.setItem(STORAGE_KEY, next);
  }
 
  private apply(theme: 'dark' | 'light'): void {
    document.documentElement.setAttribute('data-theme', theme);
  }
 
  private readInitialTheme(): 'dark' | 'light' {
    const stored = localStorage.getItem(STORAGE_KEY);
    return stored === 'light' ? 'light' : 'dark';
  }
}