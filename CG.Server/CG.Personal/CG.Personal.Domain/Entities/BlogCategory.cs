using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG.Personal.Domain.Abstractions;

namespace CG.Personal.Domain.Entities;

public sealed class BlogCategory : Entity
{
    public string Title { get; set; } = string.Empty;
}
