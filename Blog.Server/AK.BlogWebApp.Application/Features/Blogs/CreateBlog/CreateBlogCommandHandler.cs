using AutoMapper;
using AK.BlogWebApp.Application.Services;
using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Blogs.CreateBlog;

public sealed class CreateBlogCommandHandler(
       IBlogRepository blogRepository,
       IBlogCategoryRepository blogCategoryRepository,
       IFileService fileService,
       IMapper mapper,
       IUnitOfWork unitOfWork) : IRequestHandler<CreateBlogCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        BlogCategory? category = await blogCategoryRepository.GetByExpressionAsync(p => p.Id == request.BlogCategoryId);
        if (category is null)
        {
            return Result<string>.Failure("Seçilen kategori bulunamadı!!");
        }
        Blog blog = mapper.Map<Blog>(request);
        blog.CreatedDate = DateTime.Now;

        if (request.CoverImgUrl is not null)
            blog.CoverImgUrl = await fileService.UploadFile(request.CoverImgUrl, "Blogs");

        await blogRepository.AddAsync(blog);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Blog başarıyla oluşturuldu";
    }
}


