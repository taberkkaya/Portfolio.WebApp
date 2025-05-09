using AutoMapper;
using CG.Personal.Application.Services;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Blogs.CreateBlog;

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


