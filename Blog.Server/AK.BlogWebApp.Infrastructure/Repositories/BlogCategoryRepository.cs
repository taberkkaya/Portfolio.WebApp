using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using AK.BlogWebApp.Infrastructure.Context;
using GenericRepository;

namespace AK.BlogWebApp.Infrastructure.Repositories;

internal sealed class BlogCategoryRepository : Repository<BlogCategory,ApplicationDbContext>, IBlogCategoryRepository
{
    public BlogCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}