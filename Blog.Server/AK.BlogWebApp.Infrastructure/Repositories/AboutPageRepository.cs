using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using AK.BlogWebApp.Infrastructure.Context;
using GenericRepository;

namespace AK.BlogWebApp.Infrastructure.Repositories;

internal sealed class AboutPageRepository : Repository<AboutPage, ApplicationDbContext>, IAboutPageRepository
{
    public AboutPageRepository(ApplicationDbContext context) : base(context)
    {
    }
}
