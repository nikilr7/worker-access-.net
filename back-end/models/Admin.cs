using Back_end.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_end.Models
{
    [Table("admins")]
    public class Admin : Entity
    {
        public virtual string Name { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual int Age { get; set; }

        public virtual string Email { get; set; }

        // One Admin → Many Workers
        public virtual ICollection<Worker> Workers { get; set; }
    }
}