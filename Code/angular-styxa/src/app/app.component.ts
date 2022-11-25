import { HelperService } from './services/helper.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'angular-styxa';


  constructor(
    public helperService: HelperService
  ) {

  }


}
