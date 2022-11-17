import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { CurrentUser } from 'src/app/models/CurrentUser';

@Injectable({ providedIn: 'root' })
export class GeneralService {
  public _currentUser: CurrentUser | undefined;
  public _profileId: number | undefined;
  public _avatarUrl: string | undefined;
  public _roles: any[] | undefined;

  constructor(
    private _router: Router,
    private jwtHelper: JwtHelperService
  ) { }

  public getDataFromToken(): void {
    let token = localStorage.getItem('token');
    if (token) {
      const decodedToken = this.decode(token);

        if (!this._currentUser) {
            this.prepareDataFromToken(decodedToken);
        } else {
            if (this._currentUser.Id === decodedToken.Id && this._currentUser.Email === decodedToken.Email) {
                this.prepareDataFromToken(decodedToken);
            } else {
                localStorage.clear();
                this._router.navigate(['/login']);
            }
        }
    }
  }

  private prepareDataFromToken(decodedToken: CurrentUser) {
    this._currentUser = decodedToken;
    this._profileId = this._currentUser.ProfileId;
    this._avatarUrl = this._currentUser.AvatarUrl;
    this._roles = this._currentUser.Roles;
  }

  private decode(token: string): CurrentUser {
    let decoded = this.jwtHelper.decodeToken(token);

    let id = decoded['sub'];
    let username = decoded['name'];
    let user = new CurrentUser(id, username);

    user.Email = decoded['email'];
    user.FirstName = decoded['firstName'];
    user.LastName = decoded['lastName'];
    user.PhoneNumber = decoded['phoneNumber'];
    user.IsEmailVerified = decoded['isEmailVerified'] == 'True';
    user.AvatarUrl = decoded['avatarUrl'];
    user.Roles = decoded['role'];
    user.ProfileId = decoded['profileId'];

    return user;
  }
}