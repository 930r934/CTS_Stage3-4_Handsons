import { Component, OnInit } from '@angular/core';
import { IEmployee } from './employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
// export class AppComponent {
//   title = 'Hands-on2';
//   consolelogged = "Nothing logged yet";
//   logcolor = "blue";
//   /**
//    *
//    */
//   constructor() {
    
//     // setTimeout(() => {
//     //   console.log("Timer Completed content changed");
//     //   this.consolelogged = "Logged after 5 seconds";
//     // },5000);
    
//   }

//   // databinding() 
//   // {
//   //   this.consolelogged = " data binded on click";
//   //   this.logcolor = "red";
//   // }

//   // consolelog()
//   // {
//   //   this.consolelogged = " console has been logged";
//   //   this.logcolor = "orange";
//   // }

//   // switching()
//   // {
//   //   this.consolelogged = "content has been switched";
//   //   this.logcolor = "brown";
//   // }

// }
export class AppComponent implements OnInit{
  title = 'Hands-on1';
  users: any;
  jst: string = `
  {
    "FirstName" : "Jhon",
    "LastName" : "Stroke",
    "Salary" : 5000,
    "PermanentStaff" : true,
    "Skills" : [ "html","css","js","ts"]
  }`;
  obj: any;
  val: any = 45;

  customer : IEmployee = { 
    Id : 2, 
    name : "Jhon",
    salary : 30000,
    permanent : true
 } 

  constructor() {
    this.ngOnInit();

   console.log(this.customer);

  }

  ngOnInit(): void {
    this.obj = JSON.parse(this.jst);
    console.log(this.obj);
  }

  inc() {
    this.val++;
  }
  dec() {
    this.val--;
  }
}
