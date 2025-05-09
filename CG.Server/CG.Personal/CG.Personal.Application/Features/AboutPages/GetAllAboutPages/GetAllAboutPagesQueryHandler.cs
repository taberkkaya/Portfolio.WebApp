using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CG.Personal.Application.Features.AboutPages.GetAllAboutPages;

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
