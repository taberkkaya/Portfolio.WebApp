using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using AK.BlogWebApp.Infrastructure.Context;
using GenericRepository;

namespace AK.BlogWebApp.Infrastructure.Repositories;

internal sealed class DocumentRepository : Repository<Document, ApplicationDbContext>, IDocumentRepository
{
    public DocumentRepository(ApplicationDbContext context) : base(context)
    {
    }
}
