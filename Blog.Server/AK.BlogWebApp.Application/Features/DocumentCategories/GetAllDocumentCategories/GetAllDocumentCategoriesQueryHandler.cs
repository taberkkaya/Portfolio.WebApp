﻿using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.DocumentCategories.GetAllDocumentCategories;

public sealed class GetAllDocumentCategoriesQueryHandler(
    IDocumentCategoryRepository documentCategoryRepository
    ) : IRequestHandler<GetAllDocumentCategoriesQuery, Result<List<DocumentCategory>>>
{
    public async Task<Result<List<DocumentCategory>>> Handle(GetAllDocumentCategoriesQuery request, CancellationToken cancellationToken)
    {
        List<DocumentCategory>? result = await documentCategoryRepository.GetAll().ToListAsync();

        if (result is null)
        {
            return Result<List<DocumentCategory>>.Failure("Document kategorisi bulunamadı.");
        }

        return result;

    }
}
