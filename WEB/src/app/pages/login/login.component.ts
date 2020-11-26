import { LoginService } from './../../services/login.service';
import { Component, ElementRef, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { LoginModel } from './models/login-model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  form: FormGroup;
  user: FormControl;
  pass: FormControl;

  login: LoginModel;

  constructor(private elementRef: ElementRef,
              private loginService: LoginService) {

    this.user = new FormControl('', Validators.required);
    this.pass = new FormControl('', Validators.required);

    this.form = new FormGroup({
      user: this.user,
      pass: this.pass
    });

   }

  ngOnInit(): void {
    this.elementRef.nativeElement.ownerDocument.body.style.backgroundColor = '#175c7d';
  }


  onSubmit(): void{


  }

}
