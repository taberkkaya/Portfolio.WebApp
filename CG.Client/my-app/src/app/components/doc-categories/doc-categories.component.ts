import { Component, ElementRef, ViewChild } from '@angular/core';
import { DocumentCategoryModel } from '../../models/documentCategory.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { NgForm } from '@angular/forms';
import { SharedModule } from '../../modules/shared.module';
import { DocCategoryPipe } from '../../pipes/doc-category.pipe';

@Component({
  selector: 'app-doc-categories',
  standalone: true,
  imports: [SharedModule, DocCategoryPipe],
  templateUrl: './doc-categories.component.html',
  styleUrl: './doc-categories.component.css',
})
export class DocCategoriesComponent {
  categories: DocumentCategoryModel[] = [];
  search: string = '';

  @ViewChild('createModalCloseBtn') createModalCloseBtn:
    | ElementRef<HTMLButtonElement>
    | undefined;
  @ViewChild('createCategoryModalCloseBtn') createCategoryModalCloseBtn:
    | ElementRef<HTMLButtonElement>
    | undefined;

  createModel: DocumentCategoryModel = new DocumentCategoryModel();

  constructor(private http: HttpService, private swal: SwalService) {}

  ngOnInit(): void {
    this.getAll();
  }

  getAll() {
    this.http.post<DocumentCategoryModel[]>(
      'DocumentCategory/GetAll',
      {},
      (res) => {
        this.categories = res;
      }
    );
  }

  createCategory(form: NgForm) {
    this.http.post<string>(
      'DocumentCategory/Create',
      this.createModel,
      (res) => {
        this.swal.callToast(res);
        this.createModel = new DocumentCategoryModel();
        this.createCategoryModalCloseBtn?.nativeElement.click();
        this.getAll();
      }
    );
  }

  create(form: NgForm) {
    if (form.valid) {
      const model = this.http.toFormData(this.createModel);
      this.http.post<string>('DocumentCategory/Create', model, (res) => {
        this.swal.callToast(res);
        this.createModel = new DocumentCategoryModel();
        this.createModalCloseBtn?.nativeElement.click();
        this.getAll();
      });
    }
  }

  deleteById(model: DocumentCategoryModel) {
    this.swal.callSwal(
      'Veriyi Sil? UYARI!!!',
      `Kategoriye bağlı olan paylaşılan dokümanlar silinir. ${model.title} verisini silmek istiyor musunuz?`,
      () => {
        this.http.post<string>(
          'DocumentCategory/Delete',
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
