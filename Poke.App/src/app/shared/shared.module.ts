// pages
import { MenuLateralComponent } from './components/menu-lateral/menu-lateral.component';

// pages
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';

@NgModule({
  declarations: [
    MenuLateralComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ReactiveFormsModule,
  ],
  exports: [
    FormsModule,
    IonicModule,
    ReactiveFormsModule,
    MenuLateralComponent
  ]
})
export class SharedModule {}
