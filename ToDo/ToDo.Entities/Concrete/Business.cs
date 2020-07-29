using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.Entities.Concrete
{
    public class Business
    {
 
        public int Id { get; set; }
     
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public DateTime DateCreated { get; set; }
   
        public int UserId   { get; set; }

        public User User { get; set; }
    }
}
