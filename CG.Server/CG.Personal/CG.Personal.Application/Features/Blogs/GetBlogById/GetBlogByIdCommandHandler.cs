using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CG.Personal.Application.Features.Blogs.GetBlogById;

public sealed class GetBlogByIdCommandHandler(
        IBlogRepository blogRepository
    ) : IRequestHandler<GetBlogByIdCommand, Result<Blog>>
{
    public async Task<Result<Blog>> Handle(GetBlogByIdCommand request, CancellationToken cancellationToken)
    {
        var blog = await blogRepository.Where(p => p.Id == request.Id).Include(p => p.BlogCategory).FirstAsync();

        if(blog is null)
            return Result<Blog>.Failure("Blog bulunamadı!!!");

        return blog;
    }
}

