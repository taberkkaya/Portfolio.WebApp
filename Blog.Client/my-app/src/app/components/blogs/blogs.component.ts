import { Component, ElementRef, ViewChild } from '@angular/core';
import { BlogModel } from '../../models/blog.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { NgForm } from '@angular/forms';
import { SharedModule } from '../../modules/shared.module';
import { BlogPipe } from '../../pipes/blog.pipe';
import { BlogCategoryModel } from '../../models/blogCategory.model';
import { trigger } from '@angular/animations';
import { urlForImg } from '../../constants';

@Component({
  selector: 'app-blogs',
  standalone: true,
  imports: [SharedModule, BlogPipe],
  templateUrl: './blogs.component.html',
  styleUrl: './blogs.component.css',
})
export class BlogsComponent {
  blogs: BlogModel[] = [];
  blogCategories: BlogCategoryModel[] = [];
  search: string = '';

  @ViewChild('createModalCloseBtn') createModalCloseBtn:
    | ElementRef<HTMLButtonElement>
    | undefined;
  @ViewChild('updateModalCloseBtn') updateModalCloseBtn:
    | ElementRef<HTMLButtonElement>
    | undefined;
  @ViewChild('createCategoryModalCloseBtn') createCategoryModalCloseBtn:
    | ElementRef<HTMLButtonElement>
    | undefined;

  @ViewChild('coverImg') coverImg: ElementRef<HTMLInputElement> | undefined;
  @ViewChild('currentImg') currentImg: ElementRef<HTMLImageElement> | undefined;

  createModel: BlogModel = new BlogModel();
  updateModel: BlogModel = new BlogModel();
  createCategoryModel: BlogCategoryModel = new BlogCategoryModel();
  urlForImg: string = urlForImg;

  constructor(private http: HttpService, private swal: SwalService) {}

  ngOnInit(): void {
    this.getAll();
    this.getAllBlogCategories();
  }

  onFileChange(event: any, model: string) {
    const file = event.target.files[0];
    if (file) {
      if (model == 'create') {
        this.createModel.coverImgUrl = file;
      } else {
        this.updateModel.newImg = file;
        this.currentImg?.nativeElement.classList.add('opacity-50');
      }
    }
  }

  getAllBlogCategories() {
    this.http.post<BlogCategoryModel[]>('BlogCategory/GetAll', {}, (res) => {
      this.blogCategories = res;
    });
  }

  getAll() {
    this.http.post<BlogModel[]>('Blog/GetAllBlogs', {}, (res) => {
      this.blogs = res;
    });
  }

  createCategory(form: NgForm) {
    this.http.post<string>(
      'BlogCategory/Create',
      this.createCategoryModel,
      (res) => {
        this.swal.callToast(res);
        this.createCategoryModel = new BlogModel();
        this.createCategoryModalCloseBtn?.nativeElement.click();
        this.getAllBlogCategories();
      }
    );
  }

  create(form: NgForm) {
    if (form.valid) {
      const model = this.http.toFormData(this.createModel);
      this.http.post<string>('Blog/Create', model, (res) => {
        this.swal.callToast(res);
        this.createModel = new BlogModel();
        this.createModalCloseBtn?.nativeElement.click();
        this.coverImg!.nativeElement.value = '';
        this.getAll();
      });
    }
  }

  deleteById(model: BlogModel) {
    this.swal.callSwal(
      'Veriyi Sil?',
      `${model.title} verisini silmek istiyor musunuz?`,
      () => {
        this.http.post<string>('Blog/Delete', { id: model.id }, (res) => {
          this.getAll();
          this.swal.callToast(res, 'info');
        });
      }
    );
  }

  get(model: BlogModel) {
    this.updateModel = { ...model };
  }

  update(form: NgForm) {
    if (form.valid) {
      const model = this.http.toFormData(this.updateModel);
      this.http.post<string>('Blog/Update', model, (res) => {
        this.swal.callToast(res, 'info');
        this.currentImg?.nativeElement.classList.remove('opacity-50');
        this.updateModalCloseBtn?.nativeElement.click();
        this.getAll();
      });
    }
  }
}
