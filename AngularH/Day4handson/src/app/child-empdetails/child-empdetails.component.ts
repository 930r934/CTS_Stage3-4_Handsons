import { Component,Input, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-child-empdetails',
  templateUrl: './child-empdetails.component.html',
  styleUrls: ['./child-empdetails.component.css']
})
export class ChildEmpdetailsComponent implements OnInit {

  users: any;

  @Input()
  inputv!: any;

  constructor() { }

  ngOnInit(): void {
    console.log(this.inputv);
  }


  
}
