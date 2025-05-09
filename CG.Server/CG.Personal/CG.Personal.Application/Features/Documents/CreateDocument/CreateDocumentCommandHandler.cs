using AutoMapper;
using CG.Personal.Application.Services;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.Documents.CreateDocument;

public sealed class CreateDocumentCommandHandler(
       IDocumentRepository documentRepository,
       IDocumentCategoryRepository documentCategoryRepository,
       IFileService fileService,
       IMapper mapper,
       IUnitOfWork unitOfWork) : IRequestHandler<CreateDocumentCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
    {
        DocumentCategory? category = await documentCategoryRepository.GetByExpressionAsync(p => p.Id == request.DocumentCategoryId);
        if (category is null)
        {
            return Result<string>.Failure("Seçilen kategori bulunamadı!!");
        }
        Document document = mapper.Map<Document>(request);
        document.CreatedDate = DateTime.Now;

        if (request.CoverImgUrl is not null)
            document.CoverImgUrl = await fileService.UploadFile(request.CoverImgUrl, "Documents\\Img");

        if (request.DocumentUrl is not null)
            document.DocumentUrl = await fileService.UploadFile(request.DocumentUrl, "Documents\\Files");

        await documentRepository.AddAsync(document);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Document başarıyla oluşturuldu";
    }
}


