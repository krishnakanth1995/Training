import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employeearray',
  templateUrl: './employeearray.component.html',
  styleUrls: ['./employeearray.component.css']
})
export class EmployeearrayComponent implements OnInit {

  people:any[]=[
    {"name":"Sai","age":22,"dept":"HR"},
    {"name":"Krishna","age":25,"dept":"HR"},
    {"name":"Tyni","age":23,"dept":"Fianance"},
    {"name":"Srikanth","age":24,"dept":"Development"}

  ];

  constructor() { }

  ngOnInit() {
  }

}
