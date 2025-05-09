using AutoMapper;
using CG.Personal.Application.Services;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using Microsoft.AspNetCore.Http;
using TS.Result;

namespace CG.Personal.Application.Features.AboutPages.UpdateAboutPage;

public sealed class UpdateAboutPageCommandHandler(
    IAboutPageRepository aboutPageRepository, 
    IMapper mapper,
    IFileService fileService,
    IUnitOfWork unitOfWork) : IRequestHandler<UpdateAboutPageCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateAboutPageCommand request, CancellationToken cancellationToken)
    {
        AboutPage? aboutPage = await aboutPageRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id);
        if (aboutPage is null)
        {
            return Result<string>.Failure("Hakkımda sayfası bulunamadı!!");
        }

        mapper.Map(request, aboutPage);

        if (request.NewImg is not null)
        {
            fileService.DeleteFile(aboutPage.ImgUrl,"About");
            aboutPage.ImgUrl = await fileService.UploadFile(request.NewImg, "About");
        }

        if (request.NewImg is null && aboutPage.ImgUrl is null)
        {
            aboutPage.ImgUrl = "default.webp";
        }


        aboutPageRepository.Update(aboutPage);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Hakkımda sayfası başarıyla güncellendi.";
    }
}