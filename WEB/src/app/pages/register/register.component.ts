import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Register } from './models/register';

import {MatFormFieldModule} from '@angular/material/form-field';
import { PasswordValidator } from './passwordValidator';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  form: FormGroup;
  pessoa: Register;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {

    this.validacao();

  }

  validacao(): void {

    this.form = this.fb.group({
      pesNome: ['', Validators.required],
      pesUltNome: ['', Validators.required],
      pesCpf: ['', Validators.required],
      pesSenha: ['', Validators.required],
      pesConfSenha: ['', Validators.required],
      telefone: ['', Validators.required],
      email: ['', Validators.email]
    }, {
      validator: PasswordValidator.MatchPassword
    });

  }

  onSubmit(): void {

  }

}
