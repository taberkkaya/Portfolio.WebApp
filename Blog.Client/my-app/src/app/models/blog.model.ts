import { BlogCategoryModel } from './blogCategory.model';

export class BlogModel {
  id: string = '';
  title: string = '';
  content: string = '';
  coverImgUrl?: File; // File nesnesi olarak gönder
  newImg?: File; // File nesnesi olarak gönder
  blogCategoryId: string = ''; // Guid string olarak
  isFeatured: boolean = false;
  blogCategory: BlogCategoryModel = new BlogCategoryModel();
}
