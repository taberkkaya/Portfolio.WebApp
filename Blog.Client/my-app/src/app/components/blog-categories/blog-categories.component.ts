import { Component, ElementRef, ViewChild } from '@angular/core';
import { BlogCategoryModel } from '../../models/blogCategory.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { NgForm } from '@angular/forms';
import { SharedModule } from '../../modules/shared.module';
import { BlogCategoryPipe } from '../../pipes/blog-category.pipe';

@Component({
  selector: 'app-blog-categories',
  standalone: true,
  imports: [SharedModule, BlogCategoryPipe],
  templateUrl: './blog-categories.component.html',
  styleUrl: './blog-categories.component.css',
})
export class BlogCategoriesComponent {
  categories: BlogCategoryModel[] = [];
  search: string = '';

  @ViewChild('createModalCloseBtn') createModalCloseBtn:
    | ElementRef<HTMLButtonElement>
    | undefined;
  @ViewChild('createCategoryModalCloseBtn') createCategoryModalCloseBtn:
    | ElementRef<HTMLButtonElement>
    | undefined;

  createModel: BlogCategoryModel = new BlogCategoryModel();

  constructor(private http: HttpService, private swal: SwalService) {}

  ngOnInit(): void {
    this.getAll();
  }

  getAll() {
    this.http.post<BlogCategoryModel[]>('BlogCategory/GetAll', {}, (res) => {
      this.categories = res;
    });
  }

  createCategory(form: NgForm) {
    this.http.post<string>('BlogCategory/Create', this.createModel, (res) => {
      this.swal.callToast(res);
      this.createModel = new BlogCategoryModel();
      this.createCategoryModalCloseBtn?.nativeElement.click();
      this.getAll();
    });
  }

  create(form: NgForm) {
    if (form.valid) {
      const model = this.http.toFormData(this.createModel);
      this.http.post<string>('BlogCategory/Create', model, (res) => {
        this.swal.callToast(res);
        this.createModel = new BlogCategoryModel();
        this.createModalCloseBtn?.nativeElement.click();
        this.getAll();
      });
    }
  }

  deleteById(model: BlogCategoryModel) {
    this.swal.callSwal(
      'Veriyi Sil? UYARI!!!',
      `Kategoriye bağlı olan paylaşılan bloglar silinir. ${model.title} verisini silmek istiyor musunuz? `,
      () => {
        this.http.post<string>(
          'BlogCategory/Delete',
          { id: model.id },
          (res) => {
            this.getAll();
            this.swal.callToast(res, 'info');
          }
        );
      }
    );
  }
}
