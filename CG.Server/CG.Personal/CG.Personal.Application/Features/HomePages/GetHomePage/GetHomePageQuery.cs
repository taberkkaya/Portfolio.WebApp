using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.HomePages.GetHomePage;

public sealed record GetHomePageQuery : IRequest<Result<HomePage>>;
