/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CargasComponent } from './cargas.component';

describe('CargasComponent', () => {
  let component: CargasComponent;
  let fixture: ComponentFixture<CargasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CargasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CargasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
