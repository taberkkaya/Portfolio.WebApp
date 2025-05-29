import { Component } from '@angular/core';
import { HttpService } from '../../../services/http.service';
import { HeaderAreaModel } from '../../../models/header-area.model';

@Component({
  selector: 'app-ui-navbar',
  standalone: true,
  imports: [],
  templateUrl: './ui-navbar.component.html',
  styleUrl: './ui-navbar.component.css',
})
export class UiNavbarComponent {
  headerArea: HeaderAreaModel = new HeaderAreaModel();

  constructor(private http: HttpService) {}

  ngOnInit(): void {
    this.get();
  }

  get() {
    this.http.post<HeaderAreaModel>('HeaderArea/Get', {}, (res) => {
      this.headerArea = res;
    });
  }
}
