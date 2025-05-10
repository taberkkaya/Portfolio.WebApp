using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.AboutPages.GetAllAboutPages;

public sealed class GetAllAboutPagesQueryHandler(IAboutPageRepository aboutPageRepository) : IRequestHandler<GetAllAboutPagesQuery, Result<List<AboutPage>>>
{
    public async Task<Result<List<AboutPage>>> Handle(GetAllAboutPagesQuery request, CancellationToken cancellationToken)
    {
        List<AboutPage> datas = await aboutPageRepository.GetAll()
            .OrderBy(p => p.CreatedDate)
            .ToListAsync();

        return datas;
    }
}
