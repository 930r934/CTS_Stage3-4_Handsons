import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactiveedit',
  templateUrl: './reactiveedit.component.html',
  styleUrls: ['./reactiveedit.component.css']
})
export class ReactiveeditComponent implements OnInit {

  employee: any ={
    name: "Jhon",
    age: 35,
    salary: 10000,
    permanent: false,
    departmentid: 4
  }

  //name = new FormControl(this.employee.name);
  empForm = new FormGroup({
    name: new FormControl('George', [Validators.required, Validators.maxLength(10)]),
    age: new FormControl('', Validators.required)
 });

  constructor() { }

  get name() { return this.empForm.get('name'); }

  ngOnInit(): void {
  }

}
