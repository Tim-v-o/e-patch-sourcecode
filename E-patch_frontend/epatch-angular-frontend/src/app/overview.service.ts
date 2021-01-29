import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from "rxjs";
import { Measurement } from './models/Measurement';

@Injectable({
  providedIn: 'root'
})
export class OverviewService {

  constructor(private http: HttpClient) {}

  public getMeasurements(): Observable<Array<Measurement>> {
    return this.http.get<Array<Measurement>>("/tension");
  }
}
