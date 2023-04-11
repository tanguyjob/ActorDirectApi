using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActorDirectApi.Entities.Configurations
{
    public class AddressConfig //: IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(a => a.Telephone).HasMaxLength(15);
            builder.Property(a => a.ZipCode).HasMaxLength(10);
            builder.Property(a => a.Number).HasMaxLength(7);
 
        }
    }
}
