import { Component, ElementRef, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  form: FormGroup;
  user: FormControl;
  pass: FormControl;

  constructor(private elementRef: ElementRef) {

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

}
