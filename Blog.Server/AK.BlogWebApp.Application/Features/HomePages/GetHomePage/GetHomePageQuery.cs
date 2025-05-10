using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.HomePages.GetHomePage;

public sealed record GetHomePageQuery : IRequest<Result<HomePage>>;
