import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ClassService {
  constructor() {}

  deActive() {
    document.getElementById('home')?.classList.remove('active');
    document.getElementById('about')?.classList.remove('active');
    document.getElementById('blogs')?.classList.remove('active');
    document.getElementById('docs')?.classList.remove('active');
    document.getElementById('contact')?.classList.remove('active');
  }

  setActive(id: string) {
    document.getElementById(id)?.classList.add('active');
  }
}
