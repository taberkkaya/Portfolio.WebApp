import { Component } from '@angular/core';
import { UiNavbarComponent } from './ui-navbar/ui-navbar.component';

import { UiFooterComponent } from './ui-footer/ui-footer.component';
import { UiHomeComponent } from '../ui-home/ui-home.component';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-ui-layout',
  standalone: true,
  imports: [RouterOutlet, UiNavbarComponent, UiFooterComponent],
  templateUrl: './ui-layout.component.html',
  styleUrl: './ui-layout.component.css',
})
export class UiLayoutComponent {}
