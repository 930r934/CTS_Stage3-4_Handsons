import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IEmployee } from './employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Hands-on1';
  users: any;
  jst: string = `
  {
    "FirstName" : "Jhon",
    "LastName" : "Stroke",
    "Salary" : 5000,
    "PermanentStaff" : true
  }`;


  constructor(private http: HttpClient) {
    this.ngOnInit();

    var customer : IEmployee = { 
      Id : 2, 
      name : "Jhon",
      salary : 30000,
      permanent : true
   } 

   console.log(customer);

  }

  ngOnInit(): void {
   const obj = JSON.parse(this.jst);
    console.log(obj);
  }

  getUsers() {
    this.http.get('https://reqres.in/api/users').subscribe(response => {
      this.users = response;
      this.title = "got info";
      console.log(this.users.data);
    }, error => {
      console.log(error);
    })
  }
}
