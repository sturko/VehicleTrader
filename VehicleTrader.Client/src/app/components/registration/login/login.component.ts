import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { UserForm } from 'src/app/core/forms/user/UserForm';
import { AuthService } from 'src/app/services/auth.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  public form = new UserForm().Login;
  
  constructor(
    private _authService: AuthService,
    private _toastr: ToastrService,
    private _router: Router,
    private _title: Title
  ) { }

  ngOnInit(): void {
    this._title.setTitle('Login');
  }

  public login(): void {
    this._authService.login(this.form.value)
    .subscribe(
      (jwt: string) => {
        if (jwt) {
          localStorage.setItem("jwt", jwt);
          this._toastr.success('Logged In successfully');
          this._router.navigate(['/profile']);
        }
      },
      (errorMessage) => {
        let message = "";
        try {
          if(errorMessage.error.includes('Invalid username or password')){
            message = "Invalid username or password.";
          }
        }
        catch {
          message = "Something went wrong. Please contact administrator";
        }
        this._toastr.error(message);   
      });
  }
}