import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../models/user.model';
import { GeneralService } from './general-services/general.service';

@Injectable({ providedIn: 'root' })
export class AuthService {
  baseApiUrl: string = environment.baseApiUrl;
  
  constructor(
    private http: HttpClient,
    private _generalService: GeneralService,
    private jwtHelper: JwtHelperService
    ) { }

  register(user: User): Observable<any> {
    return this.http.post<any>(this.baseApiUrl + '/api/Accounts', user);
  }

  login(user: User): Observable<string> {
    return this.http.post(
      this.baseApiUrl + '/api/Accounts/login',
      user,
      { responseType: 'text' }
    );
  }

  getUserByEmail(email: any): Observable<any> {
    return this.http.get<User>(this.baseApiUrl + '/api/Accounts', email);
  }
  
  public saveToken(access_token: string, refresh_token: string) {
    if (access_token && refresh_token) {
        localStorage.setItem('token', access_token);
        localStorage.setItem('refresh_token', refresh_token);
        this._generalService.getDataFromToken();
    }
  }

  public isLoggedIn() {
    const token = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      return true;
    }
    else {
      return false;
    }
  }
}