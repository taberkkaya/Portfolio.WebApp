import { Injectable, ViewChild } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class LoadingService {
  // Loading durumunu tutan Subject
  private loadingSubject = new BehaviorSubject<boolean>(false);

  // Observable olarak dışa aktarılacak
  loading$ = this.loadingSubject.asObservable();

  // Loading'i başlatma
  show() {
    document.getElementById('spinner')?.classList.remove('d-none');
    this.loadingSubject.next(true);
  }

  // Loading'i gizleme
  hide() {
    document.getElementById('spinner')?.classList.add('d-none');
    this.loadingSubject.next(false);
  }

  // Global olarak loading durumunu kontrol etmek için bir method
  toggleLoading(state: boolean) {
    this.loadingSubject.next(state);
  }
}
