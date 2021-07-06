import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-emplist',
  templateUrl: './emplist.component.html',
  styleUrls: ['./emplist.component.css']
})
export class EmplistComponent implements OnInit {

  users: any;
  fusers: any;
  id :any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getusers();
  }

  getusers()
  {
    this.http.get('https://reqres.in/api/users').subscribe(response => {
    this.users = response;
    this.fusers=this.users.data;
    console.log(this.users);
  }, error => {
    console.log(error);
  })
  }
  
  
  search()
  {
    this.fusers = this.users.data.filter((user1 : any)=>{return user1.first_name.includes(this.id)});
  }

}
