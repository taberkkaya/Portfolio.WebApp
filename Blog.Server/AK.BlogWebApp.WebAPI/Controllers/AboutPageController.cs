using AK.BlogWebApp.Application.Features.AboutPages.CreateAboutPage;
using AK.BlogWebApp.Application.Features.AboutPages.DeleteAboutPageById;
using AK.BlogWebApp.Application.Features.AboutPages.GetActiveAboutPage;
using AK.BlogWebApp.Application.Features.AboutPages.GetAllAboutPages;
using AK.BlogWebApp.Application.Features.AboutPages.UpdateAboutPage;
using AK.BlogWebApp.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AK.BlogWebApp.WebAPI.Controllers
{
    public class AboutPageController : ApiController
    {
        public AboutPageController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutPageCommand request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteAboutPageByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(GetAllAboutPagesQuery request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);   
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetActive(GetActiveAboutPageQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);   
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromForm]UpdateAboutPageCommand request, CancellationToken cancellationToken )
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
