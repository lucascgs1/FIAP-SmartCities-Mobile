//page
import { TabsPage } from './tabs.page';

//package
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: '/tabs/home-tab',
    pathMatch: 'full'
  },
  {
    path: 'tabs',
    component: TabsPage,
    children: [
      {
        path: 'home-tab',
        loadChildren: () => import('./home/home-tab.module')
          .then(m => m.HomeTabModule)
      },
      {
        path: 'tab2',
        loadChildren: () => import('./tab2/tab2.module')
          .then(m => m.Tab2PageModule)
      },
      {
        path: '',
        redirectTo: '/tabs/home-tab',
        pathMatch: 'full'
      }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
})
export class TabsPageRoutingModule { }
