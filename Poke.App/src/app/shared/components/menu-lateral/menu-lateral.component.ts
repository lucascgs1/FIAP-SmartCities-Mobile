// model
import { Menu } from '../../../core/models/menu.model';

// package
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu-lateral',
  templateUrl: './menu-lateral.component.html',
  styleUrls: ['./menu-lateral.component.scss'],
})
export class MenuLateralComponent implements OnInit {

  public menu: Menu[] = [
    { title: 'Meus dados', url: 'dados-cliente', icon: 'person-circle' },
    { title: 'Tickets', url: 'tickets', icon: 'ticket' },
    { title: 'Sugestão', url: 'sugestoes', icon: 'help-buoy' },
    { title: 'Termos e condições', url: 'termos', icon: 'newspaper' },

  ]

  constructor() { }

  ngOnInit() { }

}
