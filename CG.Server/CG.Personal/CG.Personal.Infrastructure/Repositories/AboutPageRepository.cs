using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using CG.Personal.Infrastructure.Context;
using GenericRepository;

namespace CG.Personal.Infrastructure.Repositories;

internal sealed class AboutPageRepository : Repository<AboutPage, ApplicationDbContext>, IAboutPageRepository
{
    public AboutPageRepository(ApplicationDbContext context) : base(context)
    {
    }
}
