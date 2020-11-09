using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Dal.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
