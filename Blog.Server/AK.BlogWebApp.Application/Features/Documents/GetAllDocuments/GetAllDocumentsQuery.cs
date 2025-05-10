using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Documents.GetAllDocuments;

public sealed record GetAllDocumentsQuery() : IRequest<Result<List<Document>>>;
