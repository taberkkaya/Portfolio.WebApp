using AutoMapper;
using AK.BlogWebApp.Application.Services;
using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.UpdateBlog;

public sealed class UpdateDocumentCommandHandler(
    IBlogRepository blogRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork,
    IFileService fileService
    ) : IRequestHandler<UpdateBlogCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        Blog? blog = await blogRepository.GetByExpressionAsync(p => p.Id == request.Id);
        if (blog is null)
        {
            return Result<string>.Failure("Blog bulunamadı!!!!");
        }

        mapper.Map(request, blog);

        if (blog.CoverImgUrl is not null)
        {
            if (request.NewImg is not null)
            {
                fileService.DeleteFile(blog.CoverImgUrl, "Blogs");
                blog.CoverImgUrl = await fileService.UploadFile(request.NewImg, "Blogs");
            }

            if (request.NewImg is null && request.ImgUrl is null)
            {
                fileService.DeleteFile(blog.CoverImgUrl, "Blogs");
                blog.CoverImgUrl = string.Empty;
            }
        }

       
        blog.UpdatedDate = DateTime.Now;
        blogRepository.Update(blog);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Blog başarıyla güncellendi";
    }
}