using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.GetAllBlogsByCategory
{
    public sealed record GetAllBlogsByCategoryQuery(Guid BlogCategoryId) : IRequest<Result<List<Blog>>>;
}
