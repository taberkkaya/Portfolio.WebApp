using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.DocumentCategories.GetAllDocumentCategories;

public sealed record GetAllDocumentCategoriesQuery() : IRequest<Result<List<DocumentCategory>>>;
