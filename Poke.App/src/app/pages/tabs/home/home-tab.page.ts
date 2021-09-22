import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-home-tab',
  templateUrl: 'home-tab.page.html',
  styleUrls: ['home-tab.page.scss']
})
export class HomeTab {
  public folder: string;
  public slideOpts = {
    initialSlide: 1,
    speed: 400
  };

  public mainBanner: any = [{
    id: 1,
    url_imagem: '../../../../assets/cidades/sao-paulo.jpg',
    nome_cidade: 'São Paulo'
  },
    {
    id: 2,
    url_imagem: '../../../../assets/cidades/sao-paulo.jpg',
    nome_cidade: 'Rio de Janeiro'
  }
  ]

  constructor(
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {
    this.folder = this.activatedRoute.snapshot.paramMap.get('id');
  }



  selecionarCidade(id) {
    console.log(id);
  }


}
