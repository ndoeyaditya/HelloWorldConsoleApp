using System;

namespace HelloWorldConsoleApp.Domain
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
