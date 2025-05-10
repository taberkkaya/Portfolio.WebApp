import { Pipe, PipeTransform } from '@angular/core';
import { DocumentModel } from '../models/document.model';

@Pipe({
  name: 'doc',
  standalone: true,
})
export class DocPipe implements PipeTransform {
  transform(value: DocumentModel[], search: string): DocumentModel[] {
    if (!search) return value;

    return value.filter((p) =>
      p.title.toLocaleLowerCase().includes(search.toLocaleLowerCase())
    );
  }
}
