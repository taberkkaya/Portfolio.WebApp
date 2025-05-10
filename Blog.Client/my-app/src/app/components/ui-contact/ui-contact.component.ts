import { Component } from '@angular/core';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { ClassService } from '../../services/class.service';
import { ContactModel } from '../../models/contact.model';

@Component({
  selector: 'app-ui-contact',
  standalone: true,
  imports: [],
  templateUrl: './ui-contact.component.html',
  styleUrl: './ui-contact.component.css',
})
export class UiContactComponent {
  page: ContactModel = new ContactModel();

  constructor(
    private http: HttpService,
    private swal: SwalService,
    private active: ClassService
  ) {
    this.active.deActive();
    this.active.setActive('contact');
    this.getDatas();
  }

  getDatas() {
    this.http.post<ContactModel>('ContactPage/Get', {}, (res) => {
      this.page = res;
    });
  }
}
