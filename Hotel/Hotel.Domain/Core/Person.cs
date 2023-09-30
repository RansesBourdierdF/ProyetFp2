using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
    }
}
