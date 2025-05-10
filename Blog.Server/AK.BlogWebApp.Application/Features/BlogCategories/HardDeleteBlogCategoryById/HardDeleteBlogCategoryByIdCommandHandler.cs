using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.BlogCategories.HardDeleteBlogCategoryById;

public sealed class HardDeleteBlogCategoryByIdCommandHandler(
    IBlogCategoryRepository blogCategoryRepository,
    IUnitOfWork unitOfWork
    ) : IRequestHandler<HardDeleteBlogCategoryByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(HardDeleteBlogCategoryByIdCommand request, CancellationToken cancellationToken)
    {
        BlogCategory? category = await blogCategoryRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);
        if (category is null)
        {
            return Result<string>.Failure("Blog kategorisi bulunamadı.");
        }

        blogCategoryRepository.Delete(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Blog kategorisi başarıyla silindi.";
    }
}

