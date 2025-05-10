using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.AboutPages.GetAllAboutPages;

public sealed record GetAllAboutPagesQuery() : IRequest<Result<List<AboutPage>>>;
