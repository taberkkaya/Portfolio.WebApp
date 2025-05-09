using MediatR;
using TS.Result;

namespace CG.Personal.Application.Features.BlogCategories.HardDeleteBlogCategoryById;

public sealed record HardDeleteBlogCategoryByIdCommand(Guid Id) : IRequest<Result<string>>;

