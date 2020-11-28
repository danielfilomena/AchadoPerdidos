import { ToastrService } from 'ngx-toastr';

import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
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
      pesTel: ['', Validators.required],
      pesEmail: ['', Validators.required],
      pesSenha: ['', Validators.required],
      pesConfSenha: ['', Validators.required]
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

  validarCpf(): void {

    this.register = Object.assign({}, this.form.value);

    if (this.register.pesCpf !== '') {

      this.registerService.validarCpf(this.register.pesCpf).subscribe(
        (result: boolean) => {

          if (result){
            this.toast.warning('CPF informado já se encotra cadastrado', 'Lost & Found');
            this.form.controls.pesCpf.setErrors({incorrect: true});

          }

        }, error => {
          this.toast.error('Não foi possível realizar a validação do CPF', 'Lost & Founbd');
        });

    }

  }

  validarEmail(): void {

    this.register = Object.assign({}, this.form.value);

    if (this.register.pesEmail !== '') {

      this.registerService.ValidarEmail(this.register.pesEmail).subscribe(
        (result: boolean) => {

          if (result){
            this.toast.warning('E-mail informado já se encontra cadastrado', 'Lost & Found');
            this.form.controls.pesEmail.setErrors({incorrect: true});
          }

        }, error => {
          this.toast.error('Não foi possível realizar a validação do e-mail', 'Lost & Found');
        });

    }

  }

}
