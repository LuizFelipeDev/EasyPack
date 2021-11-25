import { Entrega } from './../_models/Entrega';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EntregaService {
  baseURL = 'https://localhost:44304/api/Entregas';

  constructor(private http: HttpClient) { }

  getEntrega(): Observable<Entrega[]> {
    return this.http.get<Entrega[]>(this.baseURL);
  }

  getEntregaById(id: number): Observable<Entrega[]> {
    return this.http.get<Entrega[]>(`${this.baseURL}/GetListEntregasById/${id}`);
  }

}
