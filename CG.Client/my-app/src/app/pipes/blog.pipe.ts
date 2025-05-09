import { Pipe, PipeTransform } from '@angular/core';
import { BlogModel } from '../models/blog.model';

@Pipe({
  name: 'blog',
  standalone: true,
})
export class BlogPipe implements PipeTransform {
  transform(value: BlogModel[], search: string): BlogModel[] {
    if (!search) return value;

    return value.filter((p) =>
      p.title.toLocaleLowerCase().includes(search.toLocaleLowerCase())
    );
  }
}
