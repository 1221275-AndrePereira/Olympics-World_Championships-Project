import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  imports: [RouterModule],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css',
  standalone: true
})

export class Dashboard {
  constructor() {
    // Dashboard initialization
  }
}
