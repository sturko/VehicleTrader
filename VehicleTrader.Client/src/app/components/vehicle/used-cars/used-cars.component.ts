import { Component, OnInit } from '@angular/core';
import { Car } from 'src/app/models/car.model';
import { UsedVehiclesService } from 'src/app/services/used-vehicles.service';

@Component({
  selector: 'app-used-cars',
  templateUrl: './used-cars.component.html',
  styleUrls: ['./used-cars.component.css']
})
export class UsedCarsComponent implements OnInit {

  cars: Car[] = [];
  constructor(private usedVehiclesService: UsedVehiclesService) { }

  ngOnInit(): void {
    this.usedVehiclesService.getAllVehicles()
    .subscribe({
      next: (cars) => {
        this.cars = cars;
      },
      error: (response) => {
        console.log(response);
      }
    });
  }

}