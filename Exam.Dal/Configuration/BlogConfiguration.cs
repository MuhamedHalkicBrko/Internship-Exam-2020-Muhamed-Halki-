using Exam.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Dal.Configuration
{
    class BlogConfiguration: BaseEntityConfiguration<Blog>
    {
        public void Conigure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(p => p.Description);

            builder
                .HasOne(u => u.User)
                .WithMany(b => b.Blogs)
                .HasForeignKey(u => u.UserID);
        }
    }
}
