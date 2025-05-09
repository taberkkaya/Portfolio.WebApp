using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.AboutPages.GetAllAboutPages;

public sealed record GetAllAboutPagesQuery() : IRequest<Result<List<AboutPage>>>;
