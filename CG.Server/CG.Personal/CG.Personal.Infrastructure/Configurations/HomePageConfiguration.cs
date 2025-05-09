using CG.Personal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Personal.Infrastructure.Configurations;

internal sealed class HomePageConfiguration : IEntityTypeConfiguration<HomePage>
{
    public void Configure(EntityTypeBuilder<HomePage> builder)
    {
        HomePage homePage = new HomePage
        {
            Id = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            HeaderTitle = "Welcome to My Personal Page",
            HeaderContent = "This is a brief description about my personal page.",
            MainTitle = "My Projects",
            MainContent = "This is a brief description about my projects.",
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        builder.HasData(homePage);
    }
}
