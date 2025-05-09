using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.GetAllDocumentsByCategory
{
    public sealed record GetAllDocumentsByCategoryQuery(Guid BlogCategoryId) : IRequest<Result<List<Blog>>>;
}
