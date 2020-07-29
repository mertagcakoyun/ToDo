using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Name).HasMaxLength(100).IsRequired();
            builder.Property(I=>I.Surname).HasMaxLength(100).IsRequired(false);
            builder.Property(I => I.Phone).HasMaxLength(50);
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();

            builder.HasMany(I => I.BusinessList).WithOne(I => I.User).HasForeignKey(I => I.UserId);
        }
    }
}
