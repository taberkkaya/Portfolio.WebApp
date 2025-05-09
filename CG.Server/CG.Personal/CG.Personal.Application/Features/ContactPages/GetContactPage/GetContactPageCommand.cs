using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.ContactPages.GetContactPage;

public sealed record GetContactPageCommand() : IRequest<Result<ContactPage>>;
