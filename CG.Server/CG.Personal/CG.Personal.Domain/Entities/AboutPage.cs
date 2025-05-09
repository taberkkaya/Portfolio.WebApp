using CG.Personal.Domain.Abstractions;

namespace CG.Personal.Domain.Entities;

public sealed class AboutPage : Entity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImgUrl { get; set; } = string.Empty;
}
