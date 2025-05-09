    using CG.Personal.Application.Features.Blogs.CreateBlog;
using CG.Personal.Application.Features.Blogs.DeleteBlogById;
using CG.Personal.Application.Features.Blogs.GetAllBlogs;
using CG.Personal.Application.Features.Blogs.GetAllBlogsByCategory;
using CG.Personal.Application.Features.Blogs.GetBlogById;
using CG.Personal.Application.Features.Blogs.UpdateBlog;
using CG.Personal.Application.Features.Documents.CreateDocument;
using CG.Personal.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CG.Personal.WebAPI.Controllers
{
    public class BlogController : ApiController
    {
        public BlogController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllBlogs(GetAllBlogsQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllBlogsByCategory(GetAllBlogsByCategoryQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetBlogById(GetBlogByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request,cancellationToken);
            return StatusCode(response.StatusCode,response);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteBlogByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromForm] UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

    }
}
