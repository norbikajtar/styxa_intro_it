import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.scss']
})
export class ChildComponent implements OnInit {

  constructor() {
  }

  @Input() instance: string | undefined;

  @Output() instanceChange = new EventEmitter();

  @Output() onAddToCartClicked = new EventEmitter<string>();

  ngOnInit(): void {
    this.instance = this.instance + 'asdasdasd';

   // this.instanceChange.emit(this.instance);

    console.log(this.instance);

  }

  ngAfterViewInit() {
    console.log('DOM is ready for this comp')
  }

}
