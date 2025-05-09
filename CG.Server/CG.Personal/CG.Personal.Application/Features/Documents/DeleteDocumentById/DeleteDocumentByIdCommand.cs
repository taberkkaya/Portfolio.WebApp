using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.DeleteDocumentById;

public sealed record DeleteDocumentByIdCommand(Guid Id) : IRequest<Result<string>>;
