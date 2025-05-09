using AutoMapper;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.HeaderAreas.UpdateHeaderArea;

public sealed class UpdateHeaderAreaCommandHandler(
    IHeaderAreaRepository headerAreaRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork
    ) : IRequestHandler<UpdateHeaderAreaCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateHeaderAreaCommand request, CancellationToken cancellationToken)
    {
        var page = await headerAreaRepository.GetByExpressionAsync(p => p.Id == request.Id);
        mapper.Map(request,page);
        headerAreaRepository.Update(page);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Bilgiler güncellendi!!!";
    }
}
