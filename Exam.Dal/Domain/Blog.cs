using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Dal.Domain
{
    public class Blog: BaseEntity
    {
        public string Description { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
