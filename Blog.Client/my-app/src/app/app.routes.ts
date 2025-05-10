import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { LayoutsComponent } from './components/layouts/layouts.component';
import { HomeComponent } from './components/home/home.component';
import { inject } from '@angular/core';
import { AuthService } from './services/auth.service';
import { ExamplesComponent } from './components/examples/examples.component';
import { BlogsComponent } from './components/blogs/blogs.component';
import { DocsComponent } from './components/docs/docs.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { HeaderAreaComponent } from './components/header-area/header-area.component';
import { ContactComponent } from './components/contact/contact.component';
import { PwdResetComponent } from './components/pwd-reset/pwd-reset.component';
import { UiLayoutComponent } from './components/ui-layout/ui-layout.component';
import { UiHomeComponent } from './components/ui-home/ui-home.component';
import { AboutComponent } from './components/about/about.component';
import { UiAboutComponent } from './components/ui-about/ui-about.component';
import { UiBlogsComponent } from './components/ui-blogs/ui-blogs.component';
import { UiDocsComponent } from './components/ui-docs/ui-docs.component';
import { UiContactComponent } from './components/ui-contact/ui-contact.component';
import { UiBlogDetailComponent } from './components/ui-blog-detail/ui-blog-detail.component';
import { UiDocDetailsComponent } from './components/ui-doc-details/ui-doc-details.component';
import { BlogCategoriesComponent } from './components/blog-categories/blog-categories.component';
import { DocCategoriesComponent } from './components/doc-categories/doc-categories.component';

export const routes: Routes = [
  {
    path: 'login',
    component: LoginComponent,
  },
  {
    path: '',
    component: UiLayoutComponent,
    children: [
      {
        path: '',
        component: UiHomeComponent,
      },
      {
        path: 'about',
        component: UiAboutComponent,
      },
      {
        path: 'blogs',
        component: UiBlogsComponent,
      },
      {
        path: 'docs',
        component: UiDocsComponent,
      },
      {
        path: 'contact',
        component: UiContactComponent,
      },
      {
        path: 'blog-detail/:id',
        component: UiBlogDetailComponent,
      },
      {
        path: 'doc-detail/:id',
        component: UiDocDetailsComponent,
      },
    ],
  },
  {
    path: 'admin',
    component: LayoutsComponent,
    canActivateChild: [() => inject(AuthService).isAuthenticated()],
    children: [
      {
        path: '',
        component: HomeComponent,
      },
      {
        path: 'blogs',
        component: BlogsComponent,
      },
      {
        path: 'docs',
        component: DocsComponent,
      },
      {
        path: 'home-page',
        component: HomePageComponent,
      },
      {
        path: 'about',
        component: AboutComponent,
      },
      {
        path: 'header-area',
        component: HeaderAreaComponent,
      },
      {
        path: 'contact',
        component: ContactComponent,
      },
      {
        path: 'blog-category',
        component: BlogCategoriesComponent,
      },
      {
        path: 'doc-category',
        component: DocCategoriesComponent,
      },
      {
        path: 'pwd-reset',
        component: PwdResetComponent,
      },
    ],
  },
];
