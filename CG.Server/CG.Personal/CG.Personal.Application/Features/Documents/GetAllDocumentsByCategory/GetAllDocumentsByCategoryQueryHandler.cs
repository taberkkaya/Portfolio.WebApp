using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.GetAllDocumentsByCategory
{
    public sealed class GetAllDocumentsByCategoryQueryHandler(
        IBlogRepository blogRepository) : IRequestHandler<GetAllDocumentsByCategoryQuery, Result<List<Blog>>>
    {
        public async Task<Result<List<Blog>>> Handle(GetAllDocumentsByCategoryQuery request, CancellationToken cancellationToken)
        {
            List<Blog>? blogs = await blogRepository.GetAll()
                .Where(p => p.BlogCategoryId == request.BlogCategoryId)
                .ToListAsync();

            if (blogs is null || blogs.Count == 0)
                return Result<List<Blog>>.Failure("Henüz bu kategoride paylaşılan bir blog yok!!");

            return blogs;
        }
    }
}
