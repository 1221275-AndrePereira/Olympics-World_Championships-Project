import { Component } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-dashboard',
  imports: [],
  templateUrl: './dashboard.html',
  styleUrls: ['./dashboard.css'],
})

export class Dashboard {
  constructor(private translate: TranslateService){
    this.translate.setDefaultLang('en');
  }
}
