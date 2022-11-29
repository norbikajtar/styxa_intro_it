import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { CityModel } from "../models/city.model";

@Injectable({
    providedIn: 'root'
})
export class CitiesService {

    constructor(private http: HttpClient) {

    }

    getCities() {
        return this.http.get<Array<CityModel>>('/cities')
    }

    saveCity(model: CityModel) {
        return this.http.post<CityModel>('/cities', model)
    }

    update(model: CityModel) {
        return this.http.put<CityModel>(`/cities/${model.id}`, model)
    }

    getCityById(id: number){
        return this.http.get<CityModel>(`/cities/${id}`)
    }


}
