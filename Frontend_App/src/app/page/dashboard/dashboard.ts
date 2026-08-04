import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-dashboard',
  imports: [RouterModule],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css',
  standalone: true
})

export class Dashboard {
  themeIsDark = false;

  constructor(private themeService: ThemeService) {
    this.themeIsDark = this.themeService.theme() === 'dark';
  }

  toggleTheme(): void {
    this.themeService.toggle();
    this.themeIsDark = this.themeService.theme() === 'dark';
  }
}
