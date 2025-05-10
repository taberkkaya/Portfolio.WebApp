using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.HeaderAreas.GetHeaderArea;

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
