import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DoctorSchaduleComponent } from './doctor-schadule.component';

describe('DoctorSchaduleComponent', () => {
  let component: DoctorSchaduleComponent;
  let fixture: ComponentFixture<DoctorSchaduleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DoctorSchaduleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DoctorSchaduleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
