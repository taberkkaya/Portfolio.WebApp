using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.BlogCategories.DeleteBlogCategoryById;

public sealed class DeleteBlogCategoryByIdCommandHandler(
    IBlogRepository blogRepository,
    IBlogCategoryRepository blogCategoryRepository,
    IUnitOfWork unitOfWork
    ) : IRequestHandler<DeleteBlogCategoryByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteBlogCategoryByIdCommand request, CancellationToken cancellationToken)
    {
        BlogCategory? category = await blogCategoryRepository.GetByExpressionAsync(p => p.Id == request.Id,cancellationToken);
        if (category is null)
        {
            return Result<string>.Failure("Blog kategorisi bulunamadı.");
        }

        var isExistBlogWihtThisCategory = await blogRepository.AnyAsync(p => p.BlogCategoryId == category.Id);
        if (isExistBlogWihtThisCategory)
            return Result<string>.Failure("Bu kategori'ye bağlı bloglar mevcut! Kategori silinemedi!!! Hard Delete deneyebilirsiniz ancak bağlı bloglarda silinecektir.!!!");

        blogCategoryRepository.Delete(category);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Blog kategorisi başarıyla silindi.";
    }
}
