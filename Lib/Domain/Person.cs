using System;

namespace Lib.Domain
{
    public class Person : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
