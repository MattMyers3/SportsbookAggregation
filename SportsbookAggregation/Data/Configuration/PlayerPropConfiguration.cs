using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsbookAggregation.Data.Models;

namespace SportsbookAggregation.Data.Configuration
{
    class PlayerPropConfiguration : IEntityTypeConfiguration<PlayerProp>
    {
        public void Configure(EntityTypeBuilder<PlayerProp> builder)
        {
            //default
        }
    }
}
