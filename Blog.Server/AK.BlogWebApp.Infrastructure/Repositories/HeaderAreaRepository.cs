using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using AK.BlogWebApp.Infrastructure.Context;
using GenericRepository;

namespace AK.BlogWebApp.Infrastructure.Repositories;

internal sealed class HeaderAreaRepository : Repository<HeaderArea, ApplicationDbContext>, IHeaderAreaRepository
{
    public HeaderAreaRepository(ApplicationDbContext context) : base(context)
    {
    }
}
