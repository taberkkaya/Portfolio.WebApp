using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.DocumentCategories.CreateDocumentCategory;

public sealed class CreateDocumentCategoryCommandHandler(
    IDocumentCategoryRepository documentCategoryRepository,
    IUnitOfWork unitOfWork
    ) : IRequestHandler<CreateDocumentCategoryCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateDocumentCategoryCommand request, CancellationToken cancellationToken)
    {
        DocumentCategory data = new()
        {
            Title = request.Title,
            CreatedDate = DateTime.Now
        };

        documentCategoryRepository.Add(data);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Döküman kategorisi başarıyla oluşturuldu.";
    }
}
