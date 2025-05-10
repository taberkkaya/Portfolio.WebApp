import { Component } from '@angular/core';
import { DocumentModel } from '../../models/document.model';
import { urlForImg } from '../../constants';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';

@Component({
  selector: 'app-ui-doc-details',
  standalone: true,
  imports: [],
  templateUrl: './ui-doc-details.component.html',
  styleUrl: './ui-doc-details.component.css',
})
export class UiDocDetailsComponent {
  itemId: any;
  doc: DocumentModel = new DocumentModel();
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
    this.http.post<DocumentModel>(
      'Document/GetDocumentById',
      { id: this.itemId },
      (res) => {
        this.doc = res;
        console.log(this.doc);
      }
    );
  }
}
