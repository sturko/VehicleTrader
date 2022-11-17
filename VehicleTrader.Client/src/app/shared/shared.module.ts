import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { AuthService } from "../services/auth.service";

@NgModule({
    imports: [
        FormsModule,
        ReactiveFormsModule
    ],
    declarations:[],
    providers: [
        AuthService
    ],
    exports:[
        FormsModule, 
        ReactiveFormsModule,
    ]
})

export class SharedModule {}