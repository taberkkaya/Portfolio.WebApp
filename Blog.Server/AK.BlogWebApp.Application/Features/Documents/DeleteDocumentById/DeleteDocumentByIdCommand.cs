using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Documents.DeleteDocumentById;

public sealed record DeleteDocumentByIdCommand(Guid Id) : IRequest<Result<string>>;
