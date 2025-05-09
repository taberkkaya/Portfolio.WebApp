using CG.Personal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Personal.Infrastructure.Configurations;

internal sealed class AboutPageConfiguration : IEntityTypeConfiguration<AboutPage>
{
    public void Configure(EntityTypeBuilder<AboutPage> builder)
    {
        AboutPage aboutPage = new AboutPage
        {
            Id = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            Title = "About Me",
            Description = "This is a brief description about me.",
            ImgUrl = "https://example.com/image.jpg",
            CreatedDate = DateTime.UtcNow,
            IsActive = true
        };

        builder.HasData(aboutPage);
    }
}
