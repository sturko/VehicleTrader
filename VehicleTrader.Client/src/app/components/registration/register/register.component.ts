import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { UserForm } from 'src/app/core/forms/user/UserForm';
import { AuthService } from 'src/app/services/auth.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  public form = new UserForm().Register;

  constructor(
    private _authService: AuthService,
    private _toastr: ToastrService,
    private _router: Router,
    private _title: Title
  ) { }

  ngOnInit(): void {
    this._title.setTitle('Registration');
  }
  
  public register(): void {
    this._authService.register(this.form.value)
    .subscribe(
      (jwt: string) => {
        if (jwt) {
          localStorage.setItem("jwt", jwt);
          this._toastr.success('Register Success');
          this._router.navigate(['/profile']);
        }
      },
      (errorMessage) => {
        for(var index in errorMessage.error) 
        {  
          this._toastr.error(errorMessage.error[index]);   
        } 
      });
  }
}