using AutoMapper;
using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.HomePages.UpdateHomePage;

public sealed class UpdateHomePageCommandHandler(
       IHomePageRepository homePageRepository,
       IMapper mapper,
       IUnitOfWork unitOfWork
    ) : IRequestHandler<UpdateHomePageCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateHomePageCommand request, CancellationToken cancellationToken)
    {
        var page = await homePageRepository
            .Where(p => p.IsActive)
            .FirstOrDefaultAsync();
        mapper.Map(request,page);
        homePageRepository.Update(page!);
        await unitOfWork.SaveChangesAsync();
        return "Ana sayfa içeriği güncellendi!!!";
    }
}
