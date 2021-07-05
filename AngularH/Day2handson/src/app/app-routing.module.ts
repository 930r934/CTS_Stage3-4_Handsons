import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditEmpComponent } from './edit-emp/edit-emp.component';
import { ViewEmpComponent } from './view-emp/view-emp.component';

const routes: Routes = [
  { path: 'edit', component: EditEmpComponent },
  { path: 'view', component: ViewEmpComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
