import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class HelperService {

    constructor(
    ) {
        console.log('meg lett krealva')
    }

    printOnConsole(text: string) {
        console.log(text);
    }

}