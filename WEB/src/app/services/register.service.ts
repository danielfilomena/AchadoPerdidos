import { Register } from './../pages/register/models/register';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  url = environment.apiUrl;

  constructor(private http: HttpClient) { }

  registrarUsuario(registro: Register): Observable<boolean> {

    return this.http.post<boolean>(this.url + 'register', registro);

  }

}
