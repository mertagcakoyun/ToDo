using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Entities.Concrete;

namespace ToDo.WebUI.Areas.Admin.Models
{
    public class TaskAddViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }

        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
        public int? AppUserId { get; set; } //Nullable<int>    1-n 
        public AppUser AppUser { get; set; }

    }
}
