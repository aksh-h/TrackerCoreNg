import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Actions } from './Actions.enum';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  APIURL = environment.APIURL;
  httpHeaders = new HttpHeaders();

  constructor(private httpclient: HttpClient) {
    this.httpHeaders = this.httpHeaders.set('content-type', 'Application/json');
  }

  GetAll(Action: String): Observable<any> {
    return this.httpclient.get(this.APIURL + Action, { headers: this.httpHeaders })
  }

  GetByCriteria(Action: String, ID: any): Observable<any> {
    return this.httpclient.get(this.APIURL + Action + "/" + ID, { headers: this.httpHeaders })
  }

  Post(Action: String, model: any) {
    return this.httpclient.post(this.APIURL + Action, model, { headers: this.httpHeaders })
  }

  Postfile(Action: String, model: any) {
    return this.httpclient.post(this.APIURL + Action, model, { reportProgress: true })
  }

  Put(Action: String, model: any) {
    return this.httpclient.put(this.APIURL + Action, model, { headers: this.httpHeaders })
  }

  Delete(Action: String, ID: number) {
    return this.httpclient.delete(this.APIURL + Action + "/" + ID, { headers: this.httpHeaders })
  }

}