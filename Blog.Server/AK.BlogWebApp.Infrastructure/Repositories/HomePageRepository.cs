using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using AK.BlogWebApp.Infrastructure.Context;
using GenericRepository;

namespace AK.BlogWebApp.Infrastructure.Repositories;

internal sealed class HomePageRepository : Repository<HomePage, ApplicationDbContext>, IHomePageRepository
{
    public HomePageRepository(ApplicationDbContext context) : base(context)
    {
    }
}
