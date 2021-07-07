import { Component } from '@angular/core';
import { EmployeeService } from './employee.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [EmployeeService]
})
export class AppComponent {
  title = 'Day4handson';
  /**
   *
   */
  data = this.eservice.getallemployees();
  idn: number = 3;
  idobj : any;
  boolt = false;

  constructor(private eservice: EmployeeService) {
    setTimeout(() => {
       this.boolt = true;
    },2000);
    this.idobj = eservice.getemployeebyid(this.idn);
  }

  serv()
  {
   this.idobj = this.eservice.getemployeebyid(this.idn);
  }

}
