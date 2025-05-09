import { Component, ElementRef, ViewChild } from '@angular/core';
import { DocumentModel } from '../../models/document.model';
import { DocumentCategoryModel } from '../../models/documentCategory.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { NgForm } from '@angular/forms';
import { urlForImg } from '../../constants';
import { SharedModule } from '../../modules/shared.module';
import { DocPipe } from '../../pipes/doc.pipe';

@Component({
  selector: 'app-docs',
  standalone: true,
  imports: [SharedModule, DocPipe],
  templateUrl: './docs.component.html',
  styleUrl: './docs.component.css',
})
export class DocsComponent {
  docs: DocumentModel[] = [];
  docsCategories: DocumentCategoryModel[] = [];
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
  @ViewChild('currentDoc') currentDoc: ElementRef<HTMLElement> | undefined;

  createModel: DocumentModel = new DocumentModel();
  updateModel: DocumentModel = new DocumentModel();
  createCategoryModel: DocumentCategoryModel = new DocumentCategoryModel();
  urlForImg: string = urlForImg;

  constructor(private http: HttpService, private swal: SwalService) {}

  ngOnInit(): void {
    this.getAll();
    this.getAllDocumentCategories();
  }

  onFileChange(event: any, model: string) {
    const file = event.target.files[0];
    if (file) {
      if (model == 'create') {
        this.createModel.coverImgUrl = file;
      } else {
        this.updateModel.newImgUrl = file;
        this.currentImg?.nativeElement.classList.add('opacity-50');
      }
    }
  }

  onFileChangeForDocs(event: any, model: string) {
    const file = event.target.files[0];
    if (file) {
      if (model == 'create') {
        this.createModel.documentUrl = file;
      } else {
        this.updateModel.newDocument = file;
      }
    }
  }

  getAllDocumentCategories() {
    this.http.post<DocumentCategoryModel[]>(
      'DocumentCategory/GetAll',
      {},
      (res) => {
        this.docsCategories = res;
      }
    );
  }

  getAll() {
    this.http.post<DocumentModel[]>('Document/GetAllDocuments', {}, (res) => {
      this.docs = res;
    });
  }

  createCategory(form: NgForm) {
    this.http.post<string>(
      'DocumentCategory/Create',
      this.createCategoryModel,
      (res) => {
        this.swal.callToast(res);
        this.createCategoryModel = new DocumentModel();
        this.createCategoryModalCloseBtn?.nativeElement.click();
        this.getAllDocumentCategories();
      }
    );
  }

  create(form: NgForm) {
    if (form.valid) {
      const model = this.http.toFormData(this.createModel);
      this.http.post<string>('Document/Create', model, (res) => {
        this.swal.callToast(res);
        this.createModel = new DocumentModel();
        this.createModalCloseBtn?.nativeElement.click();
        this.coverImg!.nativeElement.value = '';
        this.getAll();
      });
    }
  }

  deleteById(model: DocumentModel) {
    this.swal.callSwal(
      'Veriyi Sil?',
      `${model.title} verisini silmek istiyor musunuz?`,
      () => {
        this.http.post<string>('Document/Delete', { id: model.id }, (res) => {
          this.getAll();
          this.swal.callToast(res, 'info');
        });
      }
    );
  }

  get(model: DocumentModel) {
    this.updateModel = { ...model };
  }

  update(form: NgForm) {
    if (form.valid) {
      const model = this.http.toFormData(this.updateModel);
      this.http.post<string>('Document/Update', model, (res) => {
        this.swal.callToast(res, 'info');
        this.currentImg?.nativeElement.classList.remove('opacity-50');
        this.updateModalCloseBtn?.nativeElement.click();
        this.getAll();
      });
    }
  }
}
