import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateAddEmployeeComponent } from './create-add-employee.component';

describe('CreateAddEmployeeComponent', () => {
  let component: CreateAddEmployeeComponent;
  let fixture: ComponentFixture<CreateAddEmployeeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateAddEmployeeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateAddEmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
