using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using AK.BlogWebApp.Infrastructure.Context;
using GenericRepository;

namespace AK.BlogWebApp.Infrastructure.Repositories;

internal sealed class BlogRepository : Repository<Blog, ApplicationDbContext>, IBlogRepository
{
    public BlogRepository(ApplicationDbContext context) : base(context)
    {
    }
}
