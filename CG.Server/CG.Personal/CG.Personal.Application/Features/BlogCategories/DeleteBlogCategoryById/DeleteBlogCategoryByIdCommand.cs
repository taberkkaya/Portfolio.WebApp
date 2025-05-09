using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.BlogCategories.DeleteBlogCategoryById;

public sealed record DeleteBlogCategoryByIdCommand(Guid Id) : IRequest<Result<string>>;
