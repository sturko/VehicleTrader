import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { SharedModule } from "src/app/shared/shared.module";
import { UsedCarsComponent } from "./used-cars/used-cars.component";
import { VehiclesRoutingModule } from "./vehicles-routing.module";

@NgModule({
    imports: [
        CommonModule,
        VehiclesRoutingModule,
        SharedModule,
    ],
    declarations: [
        UsedCarsComponent
    ]
})
export class VehiclesModule {}