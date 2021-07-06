import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  obj = [
    { 
      id: 33,
      name: "george antony",
      age: 45,
      salary: 50000,
      emailid: "sergio@122.com",
      gender: "M"
    },
    { 
      id: 3,
      name: "Thomas Cook",
      age: 32,
      salary: 1220000,
      emailid: "sergiobusquets@122.com",
      gender: "F"
    }
  ]
  constructor() { }

  getallemployees() : object[]
  {
    return this.obj;
  }

  getemployeebyid(id: number) : any
  {
    this.obj.forEach(element => {
      if(element.id == id)
      return element;      
    });
    return null;
  }

}
