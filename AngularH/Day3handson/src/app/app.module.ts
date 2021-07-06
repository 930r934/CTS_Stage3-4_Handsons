import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewcompComponent } from './viewcomp/viewcomp.component';
import { ReactiveeditComponent } from './reactiveedit/reactiveedit.component';

@NgModule({
  declarations: [
    AppComponent,
    ViewcompComponent,
    ReactiveeditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
