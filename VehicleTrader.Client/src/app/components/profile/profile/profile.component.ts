import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { JwtHelperService } from '@auth0/angular-jwt';
import { UserForm } from 'src/app/core/forms/user/UserForm';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  public form = new UserForm().Profile;
  public isLoading: boolean = false;
  
  constructor(
    private _title: Title,
    private jwtHelper: JwtHelperService
  ) {}

  ngOnInit(): void {
    this._title.setTitle('Profile');
    this._setFormGroup();
  }

  public onSubmit(): void {
    this.isLoading = true;
    // this.form.value
  }

  isUserAuthenticated() {
    const token = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      return true;
    }
    else {
      return false;
    }
  }

  private _setFormGroup(): void {
    this.form.get('FirstName')?.setValue('', { emitEvent: false });
    this.form.get('LastName')?.setValue('');
    this.form.get('PhoneNumber')?.setValue('');
    this.form.get('Email')?.setValue('');
    this.form.get('City')?.setValue('');
  }
}