using CG.Personal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Personal.Infrastructure.Configurations;

internal sealed class HeaderAreaConfiguration : IEntityTypeConfiguration<HeaderArea>
{
    public void Configure(EntityTypeBuilder<HeaderArea> builder)
    {
        HeaderArea headerArea = new HeaderArea
        {
            Id = Guid.Parse("58EB3902-48A5-48E7-B5A8-B43847F0F6BF"),
            FirstName = "Cihan",
            LastName = "Gökpınar",
            Profession = "SAP FI Danışmanı",

        };

        builder.HasData(headerArea);
    }
}
