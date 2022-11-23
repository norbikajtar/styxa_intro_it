import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-attribute-style-class-binding',
  templateUrl: './attribute-style-class-binding.component.html',
  styleUrls: ['./attribute-style-class-binding.component.scss']
})
export class AttributeStyleClassBindingComponent implements OnInit {

  constructor() { }

  width: number = 150;

  isEnabled: boolean = true;

  link = 'https://rente.ro'

  ngOnInit(): void {
    setTimeout(() => {
      this.width = 500;
    }, 1000)
  }

}