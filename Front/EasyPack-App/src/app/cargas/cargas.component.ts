import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cargas',
  templateUrl: './cargas.component.html',
  styleUrls: ['./cargas.component.scss']
})
export class CargasComponent implements OnInit {

  cargas: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getCargas();
  }

  getCargas(){
    this.http.get('https://localhost:44304/api/Cargas/GetListCargas').subscribe(
      response=>{
        this.cargas = response;
        console.log(response);
      }, error =>{
        console.log(error);
      }
    )
  }

}
