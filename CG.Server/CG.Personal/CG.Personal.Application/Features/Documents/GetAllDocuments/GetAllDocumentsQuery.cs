using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.GetAllDocuments;

public sealed record GetAllDocumentsQuery() : IRequest<Result<List<Document>>>;
