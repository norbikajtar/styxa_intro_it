import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { IpModel } from "../models/ip.model";

@Injectable({
    providedIn: 'root'
})
export class TestService {

    constructor(private http: HttpClient) {

    }


    getIP() {
        return this.http.get<IpModel>('/ip')
    }

    getUserAgent() {
        return this.http.get<{ "user-agent": string }>('/user-agent')
    }

    getHeaders() {
        return this.http.get<{ headers: any }>('/headers')
    }

}