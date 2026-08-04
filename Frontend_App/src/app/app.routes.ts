import { Routes } from '@angular/router';
import { Dashboard } from './page/dashboard/dashboard';
import { ResultsBrowserComponent } from './components/results-browser/results-browser';

export const routes: Routes = [
    {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full'
    },
    {
        path: 'dashboard',
        component: Dashboard,
        children: [
            {
                path: '',
                component: ResultsBrowserComponent
            },
            {
                path: 'results',
                component: ResultsBrowserComponent
            }
        ]
    },
    {
        path: 'results',
        component: Dashboard,
        children: [
            {
                path: '',
                component: ResultsBrowserComponent
            }
        ]
    },
    { path: '**', redirectTo: 'dashboard' }
];
