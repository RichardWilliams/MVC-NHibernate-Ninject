using System;

namespace DomainModel
{
    public class Employee
    {
        public virtual Guid Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual Store Store { get; set; }
    }
}