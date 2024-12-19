using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tabu.Class;

namespace Tabu.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.
                HasKey(x => x.Id);
            builder
                .Property(x => x.LanguageCode)
                .HasDefaultValue("az");
            builder
                .HasOne(x => x.Language)
                .WithMany(x => x.Games)
                .HasForeignKey(x => x.LanguageCode);
            builder.HasData(new Language
            {
                Code = "az",
                Icon = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWK5zhUmkKvC-Ndo-QOdXmRgS79Wm9l2Nx_w&s",
                Name = "Azerbaycan"
            });
            builder.HasData(new Language
            {
                Code = "en",
                Icon = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWK5zhUmkKvC-Ndo-QOdXmRgS79Wm9l2Nx_w&s",
                Name = "English"
            });

        }
    }
}
