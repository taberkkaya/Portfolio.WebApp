import { Component } from '@angular/core';
import { SharedModule } from '../../modules/shared.module';
import { HomePageModel } from '../../models/home-page.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { urlForImg } from '../../constants';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css',
})
export class HomePageComponent {
  homePage: HomePageModel = new HomePageModel();

  constructor(private http: HttpService, private swal: SwalService) {}

  ngOnInit(): void {
    this.get();
  }

  get() {
    this.http.post<HomePageModel>('HomePage/Get', {}, (res) => {
      this.homePage = res;
    });
  }

  update(form: NgForm) {
    if (form.valid) {
      this.http.post<string>('HomePage/Update', this.homePage, (res) => {
        this.swal.callToast(res, 'info');
        this.get();
      });
    }
  }
}
