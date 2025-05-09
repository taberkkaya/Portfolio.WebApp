import { Component, ElementRef, ViewChild } from '@angular/core';
import { SharedModule } from '../../modules/shared.module';
import { NgForm } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { ResetPwdModel } from '../../models/reset-pwd.model';

@Component({
  selector: 'app-pwd-reset',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './pwd-reset.component.html',
  styleUrl: './pwd-reset.component.css',
})
export class PwdResetComponent {
  constructor(
    private auth: AuthService,
    private http: HttpService,
    private swal: SwalService
  ) {}

  model: ResetPwdModel = new ResetPwdModel();

  @ViewChild('password') pwdRef!: ElementRef<HTMLInputElement>;
  @ViewChild('confirm_password') confirmPwdRef!: ElementRef<HTMLInputElement>;

  showPassword() {
    this.pwdRef.nativeElement.type = 'text';
    this.confirmPwdRef.nativeElement.type = 'text';
  }

  hidePassword() {
    this.pwdRef.nativeElement.type = 'password';
    this.confirmPwdRef.nativeElement.type = 'password';
  }

  reset(form: NgForm) {
    const pwd = this.pwdRef.nativeElement;
    const confirmPwd = this.confirmPwdRef.nativeElement;

    if (form.valid) {
      if (pwd.value !== confirmPwd.value) {
        confirmPwd.setCustomValidity('Şifrelere eşleşmiyor!!!');
      } else {
        this.model.email = this.auth.user.email;
        this.http.post<string>('Auth/ResetPassword', this.model, (res) => {
          this.swal.callToast(res, 'info');
          this.pwdRef.nativeElement.value = '';
          this.confirmPwdRef.nativeElement.value = '';
        });
      }
    }
  }
}
