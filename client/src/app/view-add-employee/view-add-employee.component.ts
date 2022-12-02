import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-view-add-employee',
  templateUrl: './view-add-employee.component.html',
  styleUrls: ['./view-add-employee.component.css']
})
export class ViewAddEmployeeComponent implements OnInit {
  AddEmployee: any = {}

  constructor(private http: HttpClient, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.getAddEmployee();
  }

  getAddEmployee() {
    let id = this.route.snapshot.paramMap.get('id');
    this.http.get(`http://localhost:5087/api/employeelist/${id}`).subscribe(post => {
      this.AddEmployee = this.AddEmployee;  
    });
  }

}
