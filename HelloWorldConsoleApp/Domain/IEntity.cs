using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldConsoleApp.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
