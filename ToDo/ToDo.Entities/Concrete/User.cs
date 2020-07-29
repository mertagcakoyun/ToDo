using System.Collections.Generic;
using ToDo.Entities.Interfaces;

namespace ToDo.Entities.Concrete
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int UserId { get; set; }
        public User UserObj { get; set; }
        public List<Business> BusinessList { get; set; }
    }
}
