using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.ContactPages.GetContactPage;

public sealed record GetContactPageCommand() : IRequest<Result<ContactPage>>;
