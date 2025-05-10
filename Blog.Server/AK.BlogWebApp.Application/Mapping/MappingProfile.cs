using AutoMapper;
using AK.BlogWebApp.Application.Features.AboutPages.CreateAboutPage;
using AK.BlogWebApp.Application.Features.AboutPages.UpdateAboutPage;
using AK.BlogWebApp.Application.Features.BlogCategories.CreateBlogCategory;
using AK.BlogWebApp.Application.Features.Blogs.CreateBlog;
using AK.BlogWebApp.Application.Features.Blogs.UpdateBlog;
using AK.BlogWebApp.Application.Features.ContactPages.UpdateContactPage;
using AK.BlogWebApp.Application.Features.DocumentCategories.CreateDocumentCategory;
using AK.BlogWebApp.Application.Features.Documents.CreateDocument;
using AK.BlogWebApp.Application.Features.Documents.UpdateDocuments;
using AK.BlogWebApp.Application.Features.HeaderAreas.UpdateHeaderArea;
using AK.BlogWebApp.Application.Features.HomePages.UpdateHomePage;
using AK.BlogWebApp.Domain.Entities;

namespace AK.BlogWebApp.Application.Mapping
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
