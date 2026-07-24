import { Routes } from '@angular/router';
import { Dashboard } from './page/dashboard/dashboard';
import { TeamComponent } from './components/team/team';
export const routes: Routes = [
    
    {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full',

    },
    
    {
        path: 'dashboard', component: Dashboard
    },
    {
        path: 'team/team', component: TeamComponent  
    },
    { path: '**', redirectTo: 'dashboard' }
];
