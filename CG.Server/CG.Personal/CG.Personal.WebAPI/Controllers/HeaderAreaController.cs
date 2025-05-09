using CG.Personal.Application.Features.HeaderAreas.GetHeaderArea;
using CG.Personal.Application.Features.HeaderAreas.UpdateHeaderArea;
using CG.Personal.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CG.Personal.WebAPI.Controllers;

public class HeaderAreaController : ApiController
{
    public HeaderAreaController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Get(GetHeaderAreaCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateHeaderAreaCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
