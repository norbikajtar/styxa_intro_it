import { Router } from '@angular/router';
import { CityModel } from './../../../../models/city.model';
import { CitiesService } from './../../../../services/cities.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cities',
  templateUrl: './cities.component.html',
  styleUrls: ['./cities.component.scss']
})
export class CitiesComponent implements OnInit {

  constructor(
    private citiesService: CitiesService,
    private router: Router
  ) { }

  dataSource: Array<CityModel> = [];
  displayedColumns: string[] = ['id', 'name', 'description', 'numberPO', 'action'];

  ngOnInit(): void {
    this.citiesService.getCities().subscribe(resp => {
      console.log(resp)
      this.dataSource = resp;
    })
  }

  edit(model: CityModel) {
    this.router.navigate(['city', model.id])
  }

}
