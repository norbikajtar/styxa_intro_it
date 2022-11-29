import { CityRoutingModule } from './city-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CitiesComponent } from './components/cities/cities.component';
import { MatTableModule } from '@angular/material/table';
import { AddOrUpdateCityComponent } from './components/add-or-update-city/add-or-update-city.component';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';




@NgModule({
  declarations: [
    CitiesComponent,
    AddOrUpdateCityComponent
  ],
  imports: [
    CommonModule,
    CityRoutingModule,
    MatTableModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule
  ]
})
export class CityModule { }
