import { ToastrService } from 'ngx-toastr';

import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { RegisterService } from './../../services/register.service';
import { Register } from './models/register';
import { PasswordValidator } from './passwordValidator';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  form: FormGroup;
  register: Register;

  constructor(private fb: FormBuilder,
              private registerService: RegisterService,
              private toast: ToastrService,
              private router: Router) { }

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

    if (this.form.valid) {

      this.register = Object.assign({}, this.form.value);
      this.registerService.registrarUsuario(this.register).subscribe(
        () => {
          this.toast.success('Usuário Registrado com Sucesso!', 'Lost & Found');
          this.router.navigate(['login']);
        }, error => {
          this.toast.error('Não Foi Possível Registrar o Usuário!', 'Lost & Found');
        });
    }

  }

}
