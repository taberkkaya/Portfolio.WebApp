import { Component } from '@angular/core';
import { HeaderAreaModel } from '../../models/header-area.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { NgForm } from '@angular/forms';
import { SharedModule } from '../../modules/shared.module';

@Component({
  selector: 'app-header-area',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './header-area.component.html',
  styleUrl: './header-area.component.css',
})
export class HeaderAreaComponent {
  headerArea: HeaderAreaModel = new HeaderAreaModel();

  constructor(private http: HttpService, private swal: SwalService) {}

  ngOnInit(): void {
    this.get();
  }

  get() {
    this.http.post<HeaderAreaModel>('HeaderArea/Get', {}, (res) => {
      this.headerArea = res;
    });
  }

  update(form: NgForm) {
    if (form.valid) {
      this.http.post<string>('HeaderArea/Update', this.headerArea, (res) => {
        this.swal.callToast(res, 'info');
        this.get();
      });
    }
  }
}
