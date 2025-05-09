using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using CG.Personal.Infrastructure.Context;
using GenericRepository;

namespace CG.Personal.Infrastructure.Repositories;

internal sealed class ContactRepository : Repository<ContactPage, ApplicationDbContext>, IContactRepository
{
    public ContactRepository(ApplicationDbContext context) : base(context)
    {
    }
}
