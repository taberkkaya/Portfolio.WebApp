using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.DocumentCategories.GetAllDocumentCategories;

public sealed record GetAllDocumentCategoriesQuery() : IRequest<Result<List<DocumentCategory>>>;
