import { CitiesService } from './../../../../services/cities.service';
import { CityModel } from './../../../../models/city.model';
import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-or-update-city',
  templateUrl: './add-or-update-city.component.html',
  styleUrls: ['./add-or-update-city.component.scss']
})
export class AddOrUpdateCityComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private citiesService: CitiesService,
    private router: Router
    ) { }

  model: CityModel = {} as CityModel;

  @ViewChild('form') form: NgForm;


  ngOnInit(): void {

    let cityId = Number(this.route.snapshot.paramMap.get('id'));
    if (cityId) {
      this.citiesService.getCityById(cityId).subscribe(resp => {
        this.model = resp;
      })
    }
  }

  saveOrUpdate() {
    if(this.model.id) {
      this.update()
    } else {
      this.save()
    }
  }

  private update() {
    this.citiesService.update(this.model).subscribe(resp =>{
      this.router.navigate(['city'])
    })
  }

  private save() {
    this.citiesService.saveCity(this.model).subscribe(resp =>{
      this.router.navigate(['city'])
    })
  }

}
