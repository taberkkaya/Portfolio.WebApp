using AK.BlogWebApp.Domain.Entities;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.HeaderAreas.GetHeaderArea;

public sealed record GetHeaderAreaCommand() : IRequest<Result<HeaderArea>>;
