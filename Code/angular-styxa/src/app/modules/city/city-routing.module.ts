import { AddOrUpdateCityComponent } from './components/add-or-update-city/add-or-update-city.component';
import { CitiesComponent } from './components/cities/cities.component';

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    { path: '', component: CitiesComponent },
    { path: ':id', component: AddOrUpdateCityComponent },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class CityRoutingModule { }
