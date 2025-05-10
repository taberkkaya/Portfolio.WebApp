using AK.BlogWebApp.Application.Features.ContactPages.GetContactPage;
using AK.BlogWebApp.Application.Features.ContactPages.UpdateContactPage;
using AK.BlogWebApp.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AK.BlogWebApp.WebAPI.Controllers;

public class ContactPageController : ApiController
{
    public ContactPageController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Get(GetContactPageCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode,response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateContactPageCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
