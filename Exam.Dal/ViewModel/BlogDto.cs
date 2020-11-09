using Exam.Dal.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Exam.Dal.ViewModel
{
    public class BlogDto
    {
        public BlogDto()
        {
        }

        public BlogDto(Blog blog)
        {
            Description = blog.Description;
        }

        public string Description { get; set; }
    }
}
