import { Injectable } from "@angular/core";


@Injectable({
    providedIn: 'root'
})
export class UserService {

    constructor() {
        console.log('UserService')
    }

    user: any;

    login() {
        this.user = {
            name: 'Andor'
        }
    }

    logOut() {
        this.user = null;
    }
}