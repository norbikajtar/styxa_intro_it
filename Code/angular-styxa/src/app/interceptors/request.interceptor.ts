import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable()
export class RequestInterceptor implements HttpInterceptor {
    constructor() { }

    // private readonly baseUrl = "http://localhost:3000";
    private readonly baseUrl = "https://httpbin.org"

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        if (request.url[0] == '/') {

            request = request.clone({ url: this.baseUrl + request.url });


        }
        return next.handle(request)
    }
}