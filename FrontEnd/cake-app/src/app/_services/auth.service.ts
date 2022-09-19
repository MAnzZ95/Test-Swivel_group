import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { config } from '../config';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})

export class AuthService {

  constructor(private fb: FormBuilder, private http: HttpClient) { }
  readonly BaseURI = 'https://localhost:44337/api';


  getUserbyUserName(name:string)
  {
    return this.http.get<any>(`${config.apiUrl}/user/get`+name);    
  }

  loginUser(formData)
  {
    return this.http.post<any>(this.BaseURI + '/user/authenticate',formData);
  }
}
