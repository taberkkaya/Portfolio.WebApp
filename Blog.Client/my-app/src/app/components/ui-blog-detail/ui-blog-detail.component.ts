import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { BlogModel } from '../../models/blog.model';
import { urlForImg } from '../../constants';

@Component({
  selector: 'app-ui-blog-detail',
  standalone: true,
  imports: [],
  templateUrl: './ui-blog-detail.component.html',
  styleUrl: './ui-blog-detail.component.css',
})
export class UiBlogDetailComponent {
  itemId: any;
  blog: BlogModel = new BlogModel();
  urlForImg: string = urlForImg;

  constructor(
    private route: ActivatedRoute,
    private http: HttpService,
    private swal: SwalService
  ) {}

  ngOnInit() {
    this.itemId = this.route.snapshot.paramMap.get('id')?.toString();
    this.get();
  }

  get() {
    this.http.post<BlogModel>(
      'Blog/GetBlogById',
      { id: this.itemId },
      (res) => {
        this.blog = res;
        this.blog.content = this.blog.content.replace(/&nbsp;/g, ' ');
      }
    );
  }
}
