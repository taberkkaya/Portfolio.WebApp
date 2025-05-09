using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using CG.Personal.Infrastructure.Context;
using GenericRepository;

namespace CG.Personal.Infrastructure.Repositories;

internal sealed class BlogCategoryRepository : Repository<BlogCategory,ApplicationDbContext>, IBlogCategoryRepository
{
    public BlogCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}