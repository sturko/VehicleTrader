import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { Car } from '../models/car.model';

@Injectable({ providedIn: 'root' })
export class UsedVehiclesService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllVehicles(): Observable<Car[]> {
    return this.http.get<Car[]>(this.baseApiUrl + '/api/UsedVehicle');
  }
}