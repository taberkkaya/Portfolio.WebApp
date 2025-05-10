import { Pipe, PipeTransform } from '@angular/core';
import { DocumentCategoryModel } from '../models/documentCategory.model';

@Pipe({
  name: 'docCategory',
  standalone: true,
})
export class DocCategoryPipe implements PipeTransform {
  transform(
    value: DocumentCategoryModel[],
    search: string
  ): DocumentCategoryModel[] {
    if (!search) return value;

    return value.filter((p) =>
      p.title.toLocaleLowerCase().includes(search.toLocaleLowerCase())
    );
  }
}
