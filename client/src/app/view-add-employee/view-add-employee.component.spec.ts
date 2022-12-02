import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewAddEmployeeComponent } from './view-add-employee.component';

describe('ViewAddEmployeeComponent', () => {
  let component: ViewAddEmployeeComponent;
  let fixture: ComponentFixture<ViewAddEmployeeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewAddEmployeeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewAddEmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
