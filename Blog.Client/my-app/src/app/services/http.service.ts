import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { api } from '../constants';
import { ResultModel } from '../models/result.model';
import { AuthService } from './auth.service';
import { ErrorService } from './error.service';
import { LoadingService } from './loading.service';

@Injectable({
  providedIn: 'root',
})
export class HttpService {
  constructor(
    private http: HttpClient,
    private auth: AuthService,
    private error: ErrorService,
    private loadingService: LoadingService
  ) {}

  toFormData(model: any): FormData {
    const formData = new FormData();

    for (const key in model) {
      if (model[key] !== null && model[key] !== undefined) {
        // File mı diye kontrol et
        if (model[key] instanceof File) {
          formData.append(key, model[key]);
        } else {
          formData.append(key, model[key].toString());
        }
      }
    }

    return formData;
  }

  get<T>(
    apiUrl: string,
    callBack: (res: T) => void,
    errorCallBack?: () => void
  ) {
    // Loading içeriğini dinamik olarak değiştirme
    this.loadingService.show(); // İstediğiniz HTML içerik burada eklenebilir
    this.http
      .post<ResultModel<T>>(`${api}/${apiUrl}`, {
        headers: {
          Authorization: 'Bearer ' + this.auth.token,
        },
      })
      .subscribe({
        next: (res) => {
          if (res.data) {
            callBack(res.data);
          }
          this.loadingService.hide(); // İşlem tamamlandığında loading'i gizle
        },
        error: (err: HttpErrorResponse) => {
          this.error.errorHandler(err);

          if (errorCallBack) {
            errorCallBack();
          }
          this.loadingService.hide(); // Hata durumunda da loading'i gizle
        },
      });
  }

  post<T>(
    apiUrl: string,
    body: any,
    callBack: (res: T) => void,
    errorCallBack?: () => void
  ) {
    // Loading içeriğini dinamik olarak değiştirme
    this.loadingService.show(); // İstediğiniz HTML içerik burada eklenebilir
    this.http
      .post<ResultModel<T>>(`${api}/${apiUrl}`, body, {
        headers: {
          Authorization: 'Bearer ' + this.auth.token,
        },
      })
      .subscribe({
        next: (res) => {
          if (res.data) {
            callBack(res.data);
          }
          this.loadingService.hide();
        },
        error: (err: HttpErrorResponse) => {
          this.error.errorHandler(err);

          if (errorCallBack) {
            errorCallBack();
          }

          this.loadingService.hide();
        },
      });
  }
}
