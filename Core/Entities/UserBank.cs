using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class UserBank: BaseEntity
    {
  
        public string? Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Gender { get; set; }
    }
}
