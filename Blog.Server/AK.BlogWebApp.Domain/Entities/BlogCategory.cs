using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AK.BlogWebApp.Domain.Abstractions;

namespace AK.BlogWebApp.Domain.Entities;

public sealed class BlogCategory : Entity
{
    public string Title { get; set; } = string.Empty;
}
