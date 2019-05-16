using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mic.Volo.Asp.NetCore.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
        public string Color { get; set; }
    }
}
