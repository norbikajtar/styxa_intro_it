import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AttributeStyleClassBindingComponent } from './attribute-style-class-binding.component';

describe('AttributeStyleClassBindingComponent', () => {
  let component: AttributeStyleClassBindingComponent;
  let fixture: ComponentFixture<AttributeStyleClassBindingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AttributeStyleClassBindingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AttributeStyleClassBindingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
