import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsedCarsComponent } from './used-cars.component';

describe('UsedCarsComponent', () => {
  let component: UsedCarsComponent;
  let fixture: ComponentFixture<UsedCarsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsedCarsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UsedCarsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
