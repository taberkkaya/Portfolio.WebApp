using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.DocumentCategories.DeleteDocumentCategory
{
    public sealed record DeleteDocumentCategoryCommand(Guid Id) : IRequest<Result<string>>;
}
