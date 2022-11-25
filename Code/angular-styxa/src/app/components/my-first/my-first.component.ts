import { TestService } from './../../services/test.service';
import { HelperService } from './../../services/helper.service';
import { Component, OnInit } from '@angular/core';
import { forkJoin } from 'rxjs';

@Component({
  selector: 'app-my-first',
  templateUrl: './my-first.component.html',
  styleUrls: ['./my-first.component.scss']
})
export class MyFirstComponent implements OnInit {
  headers: any | undefined;

  constructor(
    private testService: TestService
  ) { }

  ip: string | undefined;

  list = ['Kek','Zold','Piros'];

  birthday =  new Date();


  text = "all of my letters are written with capital letters"


  async ngOnInit() {
    this.testService.getIP().subscribe(response => {
      //  console.log(response)
      this.ip = response.origin;
      this.list.push(this.ip)

    });

    forkJoin([
      this.testService.getIP(),
      this.testService.getHeaders(),
      this.testService.getUserAgent()
    ]).subscribe(([ip, headers, userAgent]) => {
      console.log(ip);
      console.log(headers);
      console.log(userAgent)
    })
  }



}

