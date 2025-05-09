using AutoMapper;
using CG.Personal.Application.Services;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.BlogCategories.CreateBlogCategory;

public sealed class CreateBlogCategoryCommandHandler(
    IBlogCategoryRepository blogCategoryRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork) : IRequestHandler<CreateBlogCategoryCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateBlogCategoryCommand request, CancellationToken cancellationToken)
    {
        BlogCategory entity =  mapper.Map<BlogCategory>(request);
        await blogCategoryRepository.AddAsync(entity, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Blog kategorisi başarıyla oluşturuldu.";
    }
}
