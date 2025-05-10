export class MenuModel {
  name: string = '';
  icon: string = '';
  url: string = '';
  isTitle: boolean = false;
  subMenus: MenuModel[] = [];
}

export const Menus: MenuModel[] = [
  {
    name: 'Ana Sayfa',
    icon: 'fa-solid fa-home',
    url: '/admin/',
    isTitle: false,
    subMenus: [],
  },

  {
    name: 'Güncel Konular',
    icon: '',
    url: '',
    isTitle: true,
    subMenus: [],
  },
  {
    name: 'Bloglar',
    icon: 'fa-solid fa-newspaper',
    url: '/admin/blogs',
    isTitle: false,
    subMenus: [],
  },
  {
    name: 'Blog Kategorisi',
    icon: 'fa-solid fa-layer-group',
    url: '/admin/blog-category',
    isTitle: false,
    subMenus: [],
  },
  {
    name: 'Süreçler ve Dokümanlar',
    icon: '',
    url: '',
    isTitle: true,
    subMenus: [],
  },
  {
    name: 'Dökümanlar',
    icon: 'fa-solid fa-file-contract',
    url: '/admin/docs',
    isTitle: false,
    subMenus: [],
  },
  {
    name: 'Doküman Kategorisi',
    icon: 'fa-solid fa-layer-group',
    url: '/admin/doc-category',
    isTitle: false,
    subMenus: [],
  },
  {
    name: 'Sayfaları Özelleştir',
    icon: '',
    url: '',
    isTitle: true,
    subMenus: [],
  },

  {
    name: 'Ana Sayfa',
    icon: 'fa-solid fa-play',
    url: '/admin/home-page',
    isTitle: false,
    subMenus: [],
  },
  {
    name: 'Header',
    icon: 'fa-regular fa-address-card',
    url: '/admin/header-area',
    isTitle: false,
    subMenus: [],
  },
  {
    name: 'Hakkımda',
    icon: 'fa-regular fa-circle-user',
    url: '/admin/about',
    isTitle: false,
    subMenus: [],
  },
  {
    name: 'İletişim',
    icon: 'fa-regular fa-address-card',
    url: '/admin/contact',
    isTitle: false,
    subMenus: [],
  },
  {
    name: 'Oturum Bilgileri',
    icon: '',
    url: '',
    isTitle: true,
    subMenus: [],
  },
  {
    name: 'Şifre Değiştir',
    icon: 'fa-solid fa-key',
    url: '/admin/pwd-reset',
    isTitle: false,
    subMenus: [],
  },
];
