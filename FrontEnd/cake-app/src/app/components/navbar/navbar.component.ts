import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/_services/auth.service';
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  @Output() public event = new EventEmitter<any>();

  show=true;
  lgout=false;
  btn=true;
  msg='Hello!';

  model={
    username:'',
    password:''
  }

  constructor(private service:AuthService, private router:Router, private toastr: ToastrService) { }

  ngOnInit(): void {
    if (localStorage.getItem('token') != null)
    this.router.navigateByUrl('/default');
    }

  login(form:NgForm){
     
    this.service.loginUser(form.value).subscribe(
      (res:any)=>{
        localStorage.setItem('token',res.token);
        this.router.navigateByUrl('/home');
        this.show=false;
        this.lgout=true;   
        this.msg='Welcome to the CakeApp';  
        this.event.emit(this.btn);   
      },
      err=>{
        if(err.status==400)
        this.toastr.error('Incorrect user name or Password','Authentication failed.');
      }
    );
  }

}
