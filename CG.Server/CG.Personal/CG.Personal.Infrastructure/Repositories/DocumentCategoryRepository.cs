using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using CG.Personal.Infrastructure.Context;
using GenericRepository;

namespace CG.Personal.Infrastructure.Repositories;

internal sealed class DocumentCategoryRepository : Repository<DocumentCategory, ApplicationDbContext>, IDocumentCategoryRepository
{
    public DocumentCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}