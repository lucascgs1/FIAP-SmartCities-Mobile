// pages
import { HomeTab } from './home-tab.page';

// module
import { HomeTabRoutingModule } from './home-tab-routing.module';

// package
import { IonicModule } from '@ionic/angular';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [
    IonicModule,
    CommonModule,
    FormsModule,
    HomeTabRoutingModule
  ],
  declarations: [HomeTab]
})

export class HomeTabModule {}
