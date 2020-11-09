using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Dal.Domain
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
