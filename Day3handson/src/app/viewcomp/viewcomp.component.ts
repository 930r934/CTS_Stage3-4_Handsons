import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { emp } from '../empdeets';
@Component({
  selector: 'app-viewcomp',
  templateUrl: './viewcomp.component.html',
  styleUrls: ['./viewcomp.component.css']
})
export class ViewcompComponent implements OnInit {
student: any = {
  name: "Alan",
  age: 35,
  class: "3D"
}

employee: any ={
        name: "Jhon",
        age: 35,
        salary: 10000,
        permanent: false,
        departmentid: 4
      }


department: any = {
  department: [
    {
      id: 4,
    dname: "roho"
  },
      {
        id: 5,
        dname:"jono"
      }
    ]
}

js: any;
  constructor() { }

  ngOnInit(): void {

  }

  change()
  {
  }

}
