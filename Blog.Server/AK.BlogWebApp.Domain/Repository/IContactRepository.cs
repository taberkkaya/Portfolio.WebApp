using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AK.BlogWebApp.Domain.Entities;
using GenericRepository;

namespace AK.BlogWebApp.Domain.Repository;

public interface IContactRepository : IRepository<ContactPage>
{
}
