using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG.Personal.Domain.Entities;
using GenericRepository;

namespace CG.Personal.Domain.Repository
{
    public interface IBlogCategoryRepository : IRepository<BlogCategory>
    {
    }
}
