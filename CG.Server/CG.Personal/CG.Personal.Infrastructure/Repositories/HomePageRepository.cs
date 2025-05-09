using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using CG.Personal.Infrastructure.Context;
using GenericRepository;

namespace CG.Personal.Infrastructure.Repositories;

internal sealed class HomePageRepository : Repository<HomePage, ApplicationDbContext>, IHomePageRepository
{
    public HomePageRepository(ApplicationDbContext context) : base(context)
    {
    }
}
