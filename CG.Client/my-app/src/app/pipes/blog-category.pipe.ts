import { Pipe, PipeTransform } from '@angular/core';
import { BlogCategoryModel } from '../models/blogCategory.model';

@Pipe({
  name: 'blogCategory',
  standalone: true,
})
export class BlogCategoryPipe implements PipeTransform {
  transform(value: BlogCategoryModel[], search: string): BlogCategoryModel[] {
    if (!search) return value;

    return value.filter((p) =>
      p.title.toLocaleLowerCase().includes(search.toLocaleLowerCase())
    );
  }
}
