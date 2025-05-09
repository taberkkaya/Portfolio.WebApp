using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.AboutPages.GetActiveAboutPage;

public sealed record GetActiveAboutPageQuery : IRequest<Result<AboutPage>>;
