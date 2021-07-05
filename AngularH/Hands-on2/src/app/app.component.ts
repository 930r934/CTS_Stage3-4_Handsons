import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Hands-on2';
  consolelogged = "Nothing logged yet";
  logcolor = "blue";
  /**
   *
   */
  constructor() {
    
    setTimeout(() => {
      console.log("Timer Completed content changed");
      this.consolelogged = "Logged after 5 seconds";
    },5000);
    
  }

  databinding() 
  {
    this.consolelogged = " data binded on click";
    this.logcolor = "red";
  }

  consolelog()
  {
    this.consolelogged = " console has been logged";
    this.logcolor = "orange";
  }

  switching()
  {
    this.consolelogged = "content has been switched";
    this.logcolor = "brown";
  }

}
