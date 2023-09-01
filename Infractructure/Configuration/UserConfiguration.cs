using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<UserBank>
    {
        public void Configure(EntityTypeBuilder<UserBank> builder)
        {
            builder.HasKey(e => e.UserId)
                   .HasName("PK_user");

            builder.ToTable("user_bank");

            builder.Property(e => e.UserId).HasColumnName("user_id");

            builder.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");

            builder.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gender");

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        }
    }
}
