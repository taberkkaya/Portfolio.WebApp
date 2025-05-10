import { Component } from '@angular/core';
import { ContactModel } from '../../models/contact.model';
import { NgForm } from '@angular/forms';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { SharedModule } from '../../modules/shared.module';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css',
})
export class ContactComponent {
  contact: ContactModel = new ContactModel();

  constructor(private http: HttpService, private swal: SwalService) {}

  ngOnInit(): void {
    this.get();
  }

  get() {
    this.http.post<ContactModel>('ContactPage/Get', {}, (res) => {
      this.contact = res;
    });
  }

  update(form: NgForm) {
    if (form.valid) {
      this.http.post<string>('ContactPage/Update', this.contact, (res) => {
        this.swal.callToast(res, 'info');
        this.get();
      });
    }
  }
}
