import { ItemModel } from './../pages/item/models/item-model';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ItemService {

  url = environment.apiUrl;

  constructor(private http: HttpClient) { }

  buscarTodosItens(): Observable<ItemModel[]>{

    return this.http.get<ItemModel[]>(this.url + 'item');

  }


}
