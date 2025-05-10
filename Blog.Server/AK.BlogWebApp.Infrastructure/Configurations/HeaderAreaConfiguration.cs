using AK.BlogWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AK.BlogWebApp.Infrastructure.Configurations;

internal sealed class HeaderAreaConfiguration : IEntityTypeConfiguration<HeaderArea>
{
    public void Configure(EntityTypeBuilder<HeaderArea> builder)
    {
        HeaderArea headerArea = new HeaderArea
        {
            Id = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            FirstName = "Ataberk",
            LastName = "Kaya",
            Profession = "Full Stack Software Developer",

        };

        builder.HasData(headerArea);
    }
}
