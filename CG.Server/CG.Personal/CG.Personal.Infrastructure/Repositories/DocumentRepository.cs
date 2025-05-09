using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using CG.Personal.Infrastructure.Context;
using GenericRepository;

namespace CG.Personal.Infrastructure.Repositories;

internal sealed class DocumentRepository : Repository<Document, ApplicationDbContext>, IDocumentRepository
{
    public DocumentRepository(ApplicationDbContext context) : base(context)
    {
    }
}
