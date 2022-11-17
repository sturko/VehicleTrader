
import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {

    constructor(
        private jwtHelper: JwtHelperService,
        private router: Router
    ) {}

    public canActivate(): boolean {
      const token = localStorage.getItem("jwt");

      if (token !== 'undefined' && token && !this.jwtHelper.isTokenExpired(token)){
        return true;
      }
      else {
        this.router.navigate(["login"]);
      }
      return false;
  }
}