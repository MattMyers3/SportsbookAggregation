using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsbookAggregation.Data.Models;

namespace SportsbookAggregation.Data
{
    public class GameLineConfiguration : IEntityTypeConfiguration<GameLine>
    {
        public void Configure(EntityTypeBuilder<GameLine> builder)
        {
            // default
        }
    }
}