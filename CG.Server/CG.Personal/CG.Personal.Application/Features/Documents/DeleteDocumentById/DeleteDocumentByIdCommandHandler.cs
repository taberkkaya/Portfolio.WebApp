using CG.Personal.Application.Services;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.DeleteDocumentById;

public sealed class DeleteDocumentByIdCommandHandler(
        IDocumentRepository documentRepository,
        IUnitOfWork unitOfWork,
        IFileService fileService
    ) : IRequestHandler<DeleteDocumentByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteDocumentByIdCommand request, CancellationToken cancellationToken)
    {
        Document? document = await documentRepository.GetByExpressionAsync(p => p.Id == request.Id);
        if(document is null)
            return Result<string>.Failure("Document bulunamadı!!");

        if (document.DocumentUrl is not null)
        {
            fileService.DeleteFile(document.DocumentUrl, "Documents\\Files");
        }

        if (document.CoverImgUrl is not null)
        {
            fileService.DeleteFile(document.CoverImgUrl, "Documents\\Img");
        }


        documentRepository.Delete(document);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Document başarıyla silindi.";
    }
}
