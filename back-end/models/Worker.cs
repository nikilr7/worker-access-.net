namespace Back_end.Models
{
    public class Worker : Entity
    {
            public virtual string Name { get; set; }

            public virtual DateTime DateOfBirth { get; set; }

            public virtual int Age { get; set; }

            public virtual string PhoneNumber { get; set; }

            public virtual string Email { get; set; }

            public virtual decimal? Salary { get; set; }
            public virtual int Experience { get; set; }

            // Foreign key
            public virtual Guid AdminId { get; set; }

            // Navigation property
            public virtual Admin Admin { get; set; }

    }
}
