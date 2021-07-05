import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-view-emp',
  templateUrl: './view-emp.component.html',
  styleUrls: ['./view-emp.component.css']
})
export class ViewEmpComponent implements OnInit {
  jst: string = `
  {
    "FirstName" : "Jhon",
    "LastName" : "Stroke",
    "Salary" : 5000,
    "PermanentStaff" : true,
    "Skills" : [ "html","css","js","ts"]
  }`;
  obj : any;
  constructor() { 
    this.ngOnInit();
  }

  ngOnInit(): void {
    this.obj = JSON.parse(this.jst);
    console.log(this.obj);
  }

}
