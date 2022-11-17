import { FormControl, FormGroup, Validators } from "@angular/forms";

export class UserForm {
    public Register: FormGroup = new FormGroup({
        FirstName: new FormControl('', [
            Validators.required,
            Validators.minLength(2),
            Validators.maxLength(64),
            Validators.pattern(/^(.*\S+.*)$/)
        ]),
        LastName: new FormControl('', [
            Validators.required,
            Validators.minLength(2),
            Validators.maxLength(64),
            Validators.pattern(/^(.*\S+.*)$/)]),
        Password: new FormControl('', [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(64),
            Validators.pattern(/^.*((?=.*[!@#$%^&*()\-_=+{};:,<.>]){1})(?=.*\d)((?=.*[a-z]){1})((?=.*[A-Z]){1}).*$/)
        ]),
        ConfirmPassword: new FormControl('', [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(64),
            Validators.pattern(/^.*((?=.*[!@#$%^&*()\-_=+{};:,<.>]){1})(?=.*\d)((?=.*[a-z]){1})((?=.*[A-Z]){1}).*$/)
        ]),
        Email: new FormControl('', [
            Validators.required,
            Validators.email
        ]),
    });

    public Login: FormGroup = new FormGroup({
        Password: new FormControl('', [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(64),
            Validators.pattern(/^.*((?=.*[!@#$%^&*()\-_=+{};:,<.>]){1})(?=.*\d)((?=.*[a-z]){1})((?=.*[A-Z]){1}).*$/)
        ]),
        Email: new FormControl('', [
            Validators.required,
            Validators.email
        ]),
    });

    public Profile: FormGroup = new FormGroup({
        FirstName: new FormControl('', [Validators.required]),
        LastName: new FormControl('', [Validators.required]),
        PhoneNumber: new FormControl('', [
            Validators.minLength(10),
            Validators.pattern(/^\d+$/)
        ]),
        Email: new FormControl('', [
            Validators.required,
            Validators.email
        ]),
        City: new FormControl('')
    });
}