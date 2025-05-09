using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.HeaderAreas.GetHeaderArea;

public sealed class GetHeaderAreaCommandHandler(
    IHeaderAreaRepository headerAreaRepository
    ) : IRequestHandler<GetHeaderAreaCommand, Result<HeaderArea>>
{
    public async Task<Result<HeaderArea>> Handle(GetHeaderAreaCommand request, CancellationToken cancellationToken)
    {
        var area = await headerAreaRepository.GetFirstAsync();
        return area;
    }
}
