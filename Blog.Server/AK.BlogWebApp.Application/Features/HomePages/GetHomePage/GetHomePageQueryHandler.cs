using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.HomePages.GetHomePage;

public sealed class GetHomePageQueryHandler(
    IHomePageRepository homePageRepository,
    IBlogRepository blogRepository,
    IDocumentRepository documentRepository
    ) : IRequestHandler<GetHomePageQuery, Result<HomePage>>
{
    public async Task<Result<HomePage>> Handle(GetHomePageQuery request, CancellationToken cancellationToken)
    {
        var page = await homePageRepository
            .Where(p => p.IsActive)
            .FirstOrDefaultAsync();

        var featuredBlogs = await blogRepository.Where(b => b.IsFeatured)
            .OrderByDescending(b => b.CreatedDate)
            .Take(3)
            .ToListAsync(cancellationToken);

        var featuredDocuments = await documentRepository.Where(d => d.IsFeatured)
            .OrderByDescending(b => b.CreatedDate)
            .Take(3)
            .ToListAsync(cancellationToken);

        page!.FeaturedBlogs = featuredBlogs;
        page.FeaturedDocuments = featuredDocuments;

        return page!;
    }
}