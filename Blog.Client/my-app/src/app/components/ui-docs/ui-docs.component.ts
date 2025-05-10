import { Component, ElementRef, ViewChild } from '@angular/core';
import { ClassService } from '../../services/class.service';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { BlogCategoryModel } from '../../models/blogCategory.model';
import { DocumentModel } from '../../models/document.model';
import { urlForImg } from '../../constants';
import { DocumentCategoryModel } from '../../models/documentCategory.model';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ui-docs',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './ui-docs.component.html',
  styleUrl: './ui-docs.component.css',
})
export class UiDocsComponent {
  constructor(
    private active: ClassService,
    private http: HttpService,
    private swal: SwalService,
    private router: Router
  ) {
    this.active.deActive();
    this.active.setActive('docs');
    this.getAll();

    this.getAllDocCategories();
  }

  docCategories: BlogCategoryModel[] = [];
  docs: DocumentModel[] = [];
  filteredDocs: DocumentModel[] = [];
  paged: DocumentModel[] = [];

  urlForImg: string = urlForImg;

  selectedCategoryId: string | null = null;
  selectedCategoryName: string = 'Tüm Bloglar';

  pageSize = 3;
  currentPage = 1;

  pages: number[] = [];

  @ViewChild('pagination') paginationElement: ElementRef | undefined;

  getAllDocCategories() {
    this.http.post<DocumentCategoryModel[]>(
      'DocumentCategory/GetAll',
      {},
      (res) => {
        this.docCategories = res;
      }
    );
  }

  getAll() {
    this.http.post<DocumentModel[]>('Document/GetAllDocuments', {}, (res) => {
      this.docs = res;
      this.filteredDocs = res;
      this.pagination();
      this.getDocsByPageNum(1);
    });
  }

  filterByCategory(categoryId: string | null) {
    this.selectedCategoryId = categoryId;

    if (categoryId === null) {
      this.filteredDocs = this.docs;
      this.selectedCategoryName = 'Tüm Dokümanlar';
    } else {
      const selected = this.docCategories.find((c) => c.id === categoryId);
      this.filteredDocs = this.docs.filter(
        (b) => b.documentCategoryId === categoryId
      );
      this.selectedCategoryName = selected?.title || 'Kategori';
    }

    this.pagination();
    this.getDocsByPageNum(1);
  }

  pagination() {
    const pageCount = Math.ceil(this.filteredDocs.length / this.pageSize);
    this.pages = Array.from({ length: pageCount }, (_, i) => i + 1);
  }

  getDocsByPageNum(pageNum: number = 1) {
    this.currentPage = pageNum;
    const start = (pageNum - 1) * this.pageSize;
    const end = start + this.pageSize;
    this.paged = this.filteredDocs.slice(start, end);
  }

  showDetails(doc: DocumentModel) {
    this.router.navigate(['/doc-detail', doc.id]);
  }
}
