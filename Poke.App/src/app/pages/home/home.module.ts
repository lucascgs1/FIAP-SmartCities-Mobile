// page
import { HomePage } from './home.page';

// module
import { FolderPageRoutingModule } from './home-routing.module';

// package
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    FolderPageRoutingModule
  ],
  declarations: [HomePage]
})
export class HomePageModule { }
