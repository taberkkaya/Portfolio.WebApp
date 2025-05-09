using AutoMapper;
using CG.Personal.Application.Features.AboutPages.CreateAboutPage;
using CG.Personal.Application.Features.AboutPages.UpdateAboutPage;
using CG.Personal.Application.Features.BlogCategories.CreateBlogCategory;
using CG.Personal.Application.Features.Blogs.CreateBlog;
using CG.Personal.Application.Features.Blogs.UpdateBlog;
using CG.Personal.Application.Features.ContactPages.UpdateContactPage;
using CG.Personal.Application.Features.DocumentCategories.CreateDocumentCategory;
using CG.Personal.Application.Features.Documents.CreateDocument;
using CG.Personal.Application.Features.Documents.UpdateDocuments;
using CG.Personal.Application.Features.HeaderAreas.UpdateHeaderArea;
using CG.Personal.Application.Features.HomePages.UpdateHomePage;
using CG.Personal.Domain.Entities;

namespace CG.Personal.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateAboutPageCommand, AboutPage>();
            CreateMap<UpdateAboutPageCommand, AboutPage>();

            CreateMap<CreateBlogCommand, Blog>();
            CreateMap<UpdateBlogCommand, Blog>();

            CreateMap<CreateDocumentCommand, Document>();
            CreateMap<UpdateDocumentCommand, Document>();

            CreateMap<CreateBlogCategoryCommand, BlogCategory>();
            CreateMap<CreateDocumentCategoryCommand, DocumentCategory>();


            CreateMap<UpdateContactPageCommand, ContactPage>();
            CreateMap<UpdateHeaderAreaCommand, HeaderArea>();
            CreateMap<UpdateHomePageCommand, HomePage>();

        }
    }
}
