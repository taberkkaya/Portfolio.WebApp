import { Component, ElementRef, ViewChild } from '@angular/core';
import { AboutModel } from '../../models/about.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { NgForm } from '@angular/forms';
import { SharedModule } from '../../modules/shared.module';
import { urlForImg } from '../../constants';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './about.component.html',
  styleUrl: './about.component.css',
})
export class AboutComponent {
  aboutPage: AboutModel = new AboutModel();
  urlForImg: string = urlForImg;
  @ViewChild('currentImg') currentImg: ElementRef<HTMLImageElement> | undefined;

  ngOnInit(): void {}

  constructor(private http: HttpService, private swal: SwalService) {
    this.get();
  }

  onFileChange(event: any) {
    const file = event.target.files[0];
    if (file) {
      console.log(this.aboutPage.imgUrl);
      this.aboutPage.newImg = file;
      this.currentImg?.nativeElement.classList.add('opacity-50');
    }
  }

  get() {
    this.http.post<AboutModel>('AboutPage/GetActive', {}, (res) => {
      this.aboutPage = res;
    });
  }

  update(form: NgForm) {
    if (form.valid) {
      const model = this.http.toFormData(this.aboutPage);
      this.http.post<string>('AboutPage/Update', model, (res) => {
        this.swal.callToast(res, 'info');
        this.get();
      });
    }
  }
}
