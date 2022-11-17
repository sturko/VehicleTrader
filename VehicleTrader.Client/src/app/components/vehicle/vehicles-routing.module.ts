import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { UsedCarsComponent } from "./used-cars/used-cars.component";

const routes: Routes = [
    {
        path: 'used-cars',
        component: UsedCarsComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class VehiclesRoutingModule {}