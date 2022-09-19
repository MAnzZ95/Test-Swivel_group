import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DefaultComponent } from './components/default/default.component';
import { HomeComponent } from './components/home/home.component';
import { NavbarComponent } from './components/navbar/navbar.component';


const routes: Routes = [
  {path:'',redirectTo:'/components/app-default',pathMatch:'full'},
  {path:'default',component:DefaultComponent},
  {path:'login',component:NavbarComponent},
  {path:'home',component:HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
