import { DocumentCategoryModel } from './documentCategory.model';

export class DocumentModel {
  id: string = '';
  title: string = '';
  description: string = '';
  coverImgUrl?: File; // File nesnesi olarak gönder
  newImgUrl?: File; // File nesnesi olarak gönder
  documentUrl?: File; // File nesnesi olarak gönder
  newDocument?: File; // File nesnesi olarak gönder
  documentCategoryId: string = ''; // Guid string olarak
  isFeatured: boolean = false;
  documentCategory: DocumentCategoryModel = new DocumentCategoryModel();
}
