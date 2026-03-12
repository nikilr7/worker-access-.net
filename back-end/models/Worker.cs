namespace Back_end.models
{
    public class Worker : Entity
    {
        public virtual String Name { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual int age { get; set; }
        public virtual String PhoneNumber { get; set; }
        public virtual String Email { get; set; }
        public virtual float? Salary { get; set; }
        public virtual int Experience { get; set; }



    }
}
