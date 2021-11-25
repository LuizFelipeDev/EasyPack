import { EntregaService } from './../_services/entrega.service';
import { Component, OnInit } from '@angular/core';
import { Entrega } from '../_models/Entrega';

@Component({
  selector: 'app-entregas',
  templateUrl: './entregas.component.html',
  styleUrls: ['./entregas.component.scss']
})
export class EntregasComponent implements OnInit {

  entregas:  Entrega[] = [];
  _filtroLista: string;
  entregasFiltradas: Entrega[] = []
  keySearch: Number;

  get filtroLista(): string{
    return this._filtroLista
  }
  set filtroLista(value: string){
    this._filtroLista = value;
    this.entregasFiltradas = this.filtroLista ? this.filtrarEntrega(this.filtroLista) : this.entregas;
  }



  constructor(private entregaService: EntregaService) { }

  ngOnInit() {
    this.getEventos();
  }


  filtrarEntrega(filtrarPor: string): Entrega[]{
    this.keySearch = Number(filtrarPor);
    return this.entregas.filter(
      entrega => entrega.cargas.length === this.keySearch
    );
  }

  getEventos(){
    this.entregaService.getEntrega().subscribe(
      (_entregas: Entrega[]) =>
      {
        this.entregas = _entregas;
        this.entregasFiltradas = _entregas;
      }, error => {
        console.log(error);
      }
    )
  }

}
