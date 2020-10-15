using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsbookAggregation.Data.Models;

namespace SportsbookAggregation.Data.Configuration
{
    public class OddsBoostConfiguration : IEntityTypeConfiguration<OddsBoost>
    {
        public void Configure(EntityTypeBuilder<OddsBoost> builder)
        {
            // default
        }
    }
}