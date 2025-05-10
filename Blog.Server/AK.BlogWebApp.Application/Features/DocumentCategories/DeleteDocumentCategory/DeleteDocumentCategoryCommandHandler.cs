using AK.BlogWebApp.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.DocumentCategories.DeleteDocumentCategory
{
    public sealed class DeleteDocumentCategoryCommandHandler(
        IDocumentRepository documentRepository,
        IDocumentCategoryRepository documentCategoryRepository,
        IUnitOfWork unitOfWork
        ) : IRequestHandler<DeleteDocumentCategoryCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(DeleteDocumentCategoryCommand request, CancellationToken cancellationToken)
        {
            var existDocuments = await documentRepository.AnyAsync(p => p.DocumentCategoryId == request.Id);
            if (existDocuments)
                return "Bu kategoriye ait belgeler bulunmaktadır. Kategori silinemez.";

            var category = await documentCategoryRepository.GetByExpressionAsync(p => p.Id == request.Id);
            documentCategoryRepository.Delete(category);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Kategori silindi."; 
        }
    }
}
