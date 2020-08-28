
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Entities.Concrete;

namespace ToDo.WebUI.Areas.Admin.Models
{
    public class TaskAddViewModel
    {

       [Required(ErrorMessage ="Please enter task name")]
        public string Name { get; set; }
        public string Description { get; set; }
       [Range(0,int.MaxValue,ErrorMessage ="Please select priority status")]
        public int PriorityId { get; set; }
        


    }
}
