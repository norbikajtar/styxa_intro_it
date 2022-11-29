import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOrUpdateCityComponent } from './add-or-update-city.component';

describe('AddOrUpdateCityComponent', () => {
  let component: AddOrUpdateCityComponent;
  let fixture: ComponentFixture<AddOrUpdateCityComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddOrUpdateCityComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddOrUpdateCityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
