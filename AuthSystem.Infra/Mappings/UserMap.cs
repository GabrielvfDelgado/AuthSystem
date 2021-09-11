using AuthSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthSystem.Infra.Mappings
{
        public class UserMap : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder) 
            { 
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            }
        }
}
