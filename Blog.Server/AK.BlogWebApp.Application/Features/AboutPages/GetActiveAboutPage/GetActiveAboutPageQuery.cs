using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.AboutPages.GetActiveAboutPage;

public sealed record GetActiveAboutPageQuery : IRequest<Result<AboutPage>>;
