using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using AK.BlogWebApp.Infrastructure.Context;
using GenericRepository;

namespace AK.BlogWebApp.Infrastructure.Repositories;

internal sealed class ContactRepository : Repository<ContactPage, ApplicationDbContext>, IContactRepository
{
    public ContactRepository(ApplicationDbContext context) : base(context)
    {
    }
}
