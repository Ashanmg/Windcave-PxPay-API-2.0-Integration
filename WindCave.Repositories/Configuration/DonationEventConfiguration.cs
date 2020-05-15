using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Windcave.Model;

namespace WindCave.Data.Configuration
{
    public class DonationEventConfiguration : IEntityTypeConfiguration<DonationEvent>
    {
        public void Configure(EntityTypeBuilder<DonationEvent> builder)
        {

        }
    }
}
