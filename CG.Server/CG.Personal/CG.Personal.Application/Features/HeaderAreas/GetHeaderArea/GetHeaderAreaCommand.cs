using CG.Personal.Domain.Entities;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.HeaderAreas.GetHeaderArea;

public sealed record GetHeaderAreaCommand() : IRequest<Result<HeaderArea>>;
