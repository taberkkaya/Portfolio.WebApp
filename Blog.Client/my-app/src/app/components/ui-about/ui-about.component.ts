import { Component } from '@angular/core';
import { SharedModule } from '../../modules/shared.module';
import { AboutModel } from '../../models/about.model';
import { urlForImg } from '../../constants';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { ClassService } from '../../services/class.service';

@Component({
  selector: 'app-ui-about',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './ui-about.component.html',
  styleUrl: './ui-about.component.css',
})
export class UiAboutComponent {
  page: AboutModel = new AboutModel();
  urlForImg: string = urlForImg;

  constructor(
    private http: HttpService,
    private swal: SwalService,
    private active: ClassService
  ) {
    this.active.deActive();
    this.active.setActive('about');
    this.getDatas();
  }

  getDatas() {
    this.http.post<AboutModel>('AboutPage/GetActive', {}, (res) => {
      this.page = res;
      this.page.description = this.page.description.replace(/&nbsp;/g, ' ');
    });
  }
}
