using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsbookAggregation.Data.Models;
using System;

namespace SportsbookAggregation.Data.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(b => b.SportId).HasDefaultValue(new Guid("d6904dda-e7e7-43b1-b25d-0353f2029ab6"));
        }
    }
}