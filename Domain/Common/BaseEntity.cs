using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public Guid Identifier { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
