import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-add-employee',
  templateUrl: './create-add-employee.component.html',
  styleUrls: ['./create-add-employee.component.css']
})
export class CreateAddEmployeeComponent implements OnInit {
  model: any = {}

  constructor(
    private http: HttpClient,
    private router: Router) { }

  ngOnInit(): void {
  }

  createAddEmployee() {
    this.model.date = new Date();
    this.http.post('http://localhost:5087/api/EmployeeList', this.model).subscribe(
      response => { this.home() },
      error => { console.log(error) }
    )
  }

  cancel() {
    this.home();
  }

  home() {
    this.router.navigate(["/"]);
  }

}
