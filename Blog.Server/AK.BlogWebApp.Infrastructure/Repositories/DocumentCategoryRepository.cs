using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using AK.BlogWebApp.Infrastructure.Context;
using GenericRepository;

namespace AK.BlogWebApp.Infrastructure.Repositories;

internal sealed class DocumentCategoryRepository : Repository<DocumentCategory, ApplicationDbContext>, IDocumentCategoryRepository
{
    public DocumentCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}