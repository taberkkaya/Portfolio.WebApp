import { BlogModel } from './blog.model';
import { DocumentModel } from './document.model';

export class HomePageModel {
  headerTitle: string = '';
  headerContent: string = '';
  mainTitle: string = '';
  mainContent: string = '';
  featuredBlogs: BlogModel[] = [];
  featuredDocuments: DocumentModel[] = [];
}
