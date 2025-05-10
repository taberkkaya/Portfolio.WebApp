using AK.BlogWebApp.Application.Features.HomePages.GetHomePage;
using AK.BlogWebApp.Application.Features.HomePages.UpdateHomePage;
using AK.BlogWebApp.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AK.BlogWebApp.WebAPI.Controllers;

public class HomePageController : ApiController
{
    public HomePageController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Get(GetHomePageQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateHomePageCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}