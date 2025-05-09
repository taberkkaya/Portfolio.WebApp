using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.GetDocumentById;

public sealed record GetDocumentByIdCommand(Guid Id) : IRequest<Result<Document>>;
