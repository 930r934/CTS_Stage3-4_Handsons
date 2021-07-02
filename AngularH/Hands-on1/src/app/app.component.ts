import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Hands-on1';
  users: any;
  
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
   
  }

  getUsers() {
    this.http.get('https://reqres.in/api/users').subscribe(response => {
      this.users = response;
      this.title = "got info";
    }, error => {
      console.log(error);
    })
  }
}
