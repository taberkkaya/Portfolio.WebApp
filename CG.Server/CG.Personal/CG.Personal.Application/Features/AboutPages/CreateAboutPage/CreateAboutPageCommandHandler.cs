using System.Runtime.InteropServices;
using AutoMapper;
using CG.Personal.Application.Services;
using CG.Personal.Domain.Entities;
using CG.Personal.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.AboutPages.CreateAboutPage;

public sealed class CreateAboutPageCommandHandler(
    IAboutPageRepository aboutPageRepository,
    IFileService fileService,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateAboutPageCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateAboutPageCommand request, CancellationToken cancellationToken)
    {
        AboutPage aboutPage = mapper.Map<AboutPage>(request);
        aboutPage.IsActive = true;
        aboutPage.CreatedDate = DateTime.Now;

        if (request.ImgUrl is not null)
        {
            aboutPage.ImgUrl =  await fileService.UploadFile(request.ImgUrl,"AboutPageImages");
        }


        await aboutPageRepository.AddAsync(aboutPage, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        await DeactiveOthers(aboutPage.Id, cancellationToken);
        return "Hakkımda sayfası başarıyla oluşturuldu.";
    }

    public async Task DeactiveOthers(Guid except,CancellationToken cancellationToken)
    {
        var aboutPages = aboutPageRepository.WhereWithTracking(x => x.IsActive && x.Id != except);
        foreach (var aboutPage in aboutPages)
        {
            aboutPage.IsActive = false;
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
