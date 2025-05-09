using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.GetAllDocuments;

public sealed class GetAllDocumentsQueryHandler(
    IDocumentRepository documentRepository) : IRequestHandler<GetAllDocumentsQuery, Result<List<Document>>>
{
    public async Task<Result<List<Document>>> Handle(GetAllDocumentsQuery request, CancellationToken cancellationToken)
    {
        List<Document> documents = await documentRepository.GetAll().ToListAsync();
        if (documents is null || documents.Count == 0)
        {
            return Result<List<Document>>.Failure("Henüz paylaşılan document yok.!!");
        }
        return documents;
    }
}
