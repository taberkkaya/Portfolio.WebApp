﻿using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.BlogCategories.GetAllBlogCategories;

public sealed class GetAllDocumentCategoriesQueryHandler(
    IBlogCategoryRepository blogCategoryRepository
    ) : IRequestHandler<GetAllBlogCategoriesQuery, Result<List<BlogCategory>>>
{
    public async Task<Result<List<BlogCategory>>> Handle(GetAllBlogCategoriesQuery request, CancellationToken cancellationToken)
    {
        List<BlogCategory>? result = await blogCategoryRepository.GetAll().ToListAsync();

        if (result is null)
        {
            return Result<List<BlogCategory>>.Failure("Blog kategorisi bulunamadı.");
        }

        return result;

    }
}
