using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsbookAggregation.Data.Models;

namespace SportsbookAggregation.Data
{
    public class GamblingSiteConfiguration : IEntityTypeConfiguration<GamblingSite>
    {
        public void Configure(EntityTypeBuilder<GamblingSite> builder)
        {
            // default
        }
    }
}