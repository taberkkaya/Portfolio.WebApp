using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.DocumentCategories.CreateDocumentCategory;

public sealed record CreateDocumentCategoryCommand(string Title) : IRequest<Result<string>>;
