import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ReactiveeditComponent } from './reactiveedit/reactiveedit.component';
import { ViewcompComponent } from './viewcomp/viewcomp.component';

const routes: Routes = [
  {path: 'view', component: ViewcompComponent},
  {path: 'redit', component: ReactiveeditComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
