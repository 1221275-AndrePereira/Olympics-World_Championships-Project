import { Routes } from '@angular/router';
import { QuotaBoardComponent } from './components/quota-board/quota-board';
export const routes: Routes = [
    
    {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full',

    },
    
    {
        path: 'dashboard', component: QuotaBoardComponent
    },
    { path: '**', redirectTo: 'dashboard' }
];
