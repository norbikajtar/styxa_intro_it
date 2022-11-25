import { Directive, ElementRef, EventEmitter, HostListener, Input, Output } from '@angular/core';

@Directive({
  selector: '[appHighlight]',
  // There are other properties as well
})
export class HighlightDirective {

  constructor(private el: ElementRef) { }

  isHighlighted: boolean = false;

  @Input('appHighlight') highlightColor: string | null | undefined;
  @Output('onChange') onChange = new EventEmitter<boolean>();

  @HostListener('mouseenter') onMouseEnter() {
    this.isHighlighted = true;
    this.highlight(this.highlightColor || 'red');
    this.onChange.emit(this.isHighlighted);
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.isHighlighted = false;
    this.highlight(null);
    this.onChange.emit(this.isHighlighted);
  }

  private highlight(color: string | null) {
    this.el.nativeElement.style.backgroundColor = color;
  }
}