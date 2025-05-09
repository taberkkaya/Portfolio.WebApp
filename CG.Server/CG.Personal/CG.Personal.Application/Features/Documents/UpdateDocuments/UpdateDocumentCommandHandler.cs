using AutoMapper;
using CG.Personal.Application.Services;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.UpdateDocuments;

public sealed class UpdateDocumentCommandHandler(
    IDocumentRepository documentRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork,
    IFileService fileService
    ) : IRequestHandler<UpdateDocumentCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateDocumentCommand request, CancellationToken cancellationToken)
    {
        Document? document = await documentRepository.GetByExpressionAsync(p => p.Id == request.Id);
        if (document is null)
        {
            return Result<string>.Failure("Document bulunamadı!!!!");
        }

        mapper.Map(request, document);

        if (request.NewImgUrl is not null)
        {
            fileService.DeleteFile(document.CoverImgUrl,"Documents\\Img");
            document.CoverImgUrl = await fileService.UploadFile(request.NewImgUrl, "Documents\\Img");
        }

        if (request.NewDocument is not null)
        {
            fileService.DeleteFile(document.DocumentUrl, "Documents\\Img");
            document.DocumentUrl = await fileService.UploadFile(request.NewDocument, "Documents\\Files");
        }

 
        document.UpdatedDate = DateTime.Now;
        documentRepository.Update(document);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Document başarıyla güncellendi";
    }
}