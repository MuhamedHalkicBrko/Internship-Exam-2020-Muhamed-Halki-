using Exam.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Dal.Configuration
{
    class UserConfiguration: BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name);
            builder.Property(p => p.Age);
            builder.Property(p => p.Email);
            builder.Property(p => p.Password);

            builder
                .HasMany(b => b.Blogs)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.User);
                
        }
    }
}
