import { Component, ElementRef, ViewChild } from '@angular/core';
import { ClassService } from '../../services/class.service';
import { BlogCategoryModel } from '../../models/blogCategory.model';
import { BlogModel } from '../../models/blog.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { urlForImg } from '../../constants';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ui-blogs',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './ui-blogs.component.html',
  styleUrl: './ui-blogs.component.css',
})
export class UiBlogsComponent {
  constructor(
    private active: ClassService,
    private http: HttpService,
    private swal: SwalService,
    private router: Router
  ) {
    this.active.deActive();
    this.active.setActive('blogs');
    this.getAll();

    this.getAllBlogCategories();
  }

  blogCategories: BlogCategoryModel[] = [];
  blogs: BlogModel[] = [];
  filteredBlogs: BlogModel[] = [];
  paged: BlogModel[] = [];

  urlForImg: string = urlForImg;

  selectedCategoryId: string | null = null;
  selectedCategoryName: string = 'Tüm Bloglar';

  pageSize = 3;
  currentPage = 1;

  pages: number[] = [];

  @ViewChild('pagination') paginationElement: ElementRef | undefined;

  getAllBlogCategories() {
    this.http.post<BlogCategoryModel[]>('BlogCategory/GetAll', {}, (res) => {
      this.blogCategories = res;
    });
  }

  getAll() {
    this.http.post<BlogModel[]>('Blog/GetAllBlogs', {}, (res) => {
      this.blogs = res;
      this.filteredBlogs = res;
      this.pagination();
      this.getBlogsByPageNum(1);
    });
  }

  filterByCategory(categoryId: string | null) {
    this.selectedCategoryId = categoryId;

    if (categoryId === null) {
      this.filteredBlogs = this.blogs;
      this.selectedCategoryName = 'Tüm Bloglar';
    } else {
      const selected = this.blogCategories.find((c) => c.id === categoryId);
      this.filteredBlogs = this.blogs.filter(
        (b) => b.blogCategoryId === categoryId
      );
      this.selectedCategoryName = selected?.title || 'Kategori';
    }

    this.pagination();
    this.getBlogsByPageNum(1);
  }

  pagination() {
    const pageCount = Math.ceil(this.filteredBlogs.length / this.pageSize);
    this.pages = Array.from({ length: pageCount }, (_, i) => i + 1);
  }

  getBlogsByPageNum(pageNum: number = 1) {
    this.currentPage = pageNum;
    const start = (pageNum - 1) * this.pageSize;
    const end = start + this.pageSize;
    this.paged = this.filteredBlogs.slice(start, end);
  }

  showDetails(blog: BlogModel) {
    this.router.navigate(['/blog-detail', blog.id]);
  }
}
