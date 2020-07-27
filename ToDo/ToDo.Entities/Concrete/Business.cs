using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Entities.Concrete
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
