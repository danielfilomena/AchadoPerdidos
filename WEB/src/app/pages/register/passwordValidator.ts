import { AbstractControl } from '@angular/forms';

export class PasswordValidator {

  static MatchPassword(ac: AbstractControl): boolean {

    const pass = ac.get('pesSenha').value;
    const confPass = ac.get('pesConfSenha').value;

    if (pass !== confPass) {

      ac.get('pesConfSenha').setErrors( { MatchPassword: true });

    } else {

      return false;

    }

  }

}
