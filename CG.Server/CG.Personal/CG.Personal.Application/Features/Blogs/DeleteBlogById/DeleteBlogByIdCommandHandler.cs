using CG.Personal.Application.Services;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Blogs.DeleteBlogById;

public sealed class DeleteBlogByIdCommandHandler(
        IBlogRepository blogRepository,
        IUnitOfWork unitOfWork,
        IFileService fileService
    ) : IRequestHandler<DeleteBlogByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteBlogByIdCommand request, CancellationToken cancellationToken)
    {
        Blog? blog = await blogRepository.GetByExpressionAsync(p => p.Id == request.Id);
        if(blog is null)
            return Result<string>.Failure("Blog bulunamadı!!");

        if(blog.CoverImgUrl is not null)
        {
            fileService.DeleteFile(blog.CoverImgUrl,"Blogs");
        }

        blogRepository.Delete(blog);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Blog başarıyla silindi.";
    }
}
