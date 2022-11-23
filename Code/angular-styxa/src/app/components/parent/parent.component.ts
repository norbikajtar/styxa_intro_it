import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.scss']
})
export class ParentComponent  {

  constructor() {

    setTimeout(()=>{
      console.log(this.first);
      console.log(this.second)
    }, 3000)
   }

  first: string = 'elso';
  second: string = 'masodik';

  addToCart(data: string){
    console.log('Kosarba', data)
  }

 

}
