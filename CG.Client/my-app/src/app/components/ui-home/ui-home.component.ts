import { Component, ElementRef, ViewChild } from '@angular/core';
import { SharedModule } from '../../modules/shared.module';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { HomePageModel } from '../../models/home-page.model';
import { BlogModel } from '../../models/blog.model';
import { DocumentModel } from '../../models/document.model';
import { urlForImg } from '../../constants';
import { ClassService } from '../../services/class.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ui-home',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './ui-home.component.html',
  styleUrl: './ui-home.component.css',
})
export class UiHomeComponent {
  page: HomePageModel = new HomePageModel();
  blogs: BlogModel[] = [];
  docs: DocumentModel[] = [];
  urlForImg: string = urlForImg;

  constructor(
    private http: HttpService,
    private swal: SwalService,
    private active: ClassService,
    private router: Router
  ) {
    this.active.deActive();
    this.active.setActive('home');
    this.getDatas();
  }

  showDetailsForDoc(doc: DocumentModel) {
    this.router.navigate(['/doc-detail', doc.id]);
  }

  showDetailsForBlog(blog: BlogModel) {
    this.router.navigate(['/blog-detail', blog.id]);
  }

  getDatas() {
    this.http.post<HomePageModel>('HomePage/Get', {}, (res) => {
      this.page = res;
      this.blogs = this.page.featuredBlogs;
      this.docs = this.page.featuredDocuments;
    });
  }
}
