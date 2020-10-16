using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsbookAggregation.Data.Models;

namespace SportsbookAggregation.Data.Configuration
{
    class PropBetTypeConfiguration : IEntityTypeConfiguration<PropBetType>
    {
        public void Configure(EntityTypeBuilder<PropBetType> builder)
        {
            //default
        }
    }
}
