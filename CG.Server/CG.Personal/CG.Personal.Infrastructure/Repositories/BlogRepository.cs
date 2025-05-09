using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using CG.Personal.Infrastructure.Context;
using GenericRepository;

namespace CG.Personal.Infrastructure.Repositories;

internal sealed class BlogRepository : Repository<Blog, ApplicationDbContext>, IBlogRepository
{
    public BlogRepository(ApplicationDbContext context) : base(context)
    {
    }
}
