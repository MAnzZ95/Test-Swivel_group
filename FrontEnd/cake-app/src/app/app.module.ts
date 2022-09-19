import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { AuthService } from './_services/auth.service';
import { HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { NavbarComponent } from './components/navbar/navbar.component';
import { HomeComponent } from './components/home/home.component';
import { AlertComponent } from './components/alert/alert.component';
import { ToastrModule } from 'ngx-toastr';
import { DefaultComponent } from './components/default/default.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    AlertComponent,
    DefaultComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    ReactiveFormsModule  
   
  ],
  providers: [
    AuthService 
  
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
