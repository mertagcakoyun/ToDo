using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.WebUI.Areas.Admin.Models
{
    public class PriorityUpdateViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Description")]
        [Required(ErrorMessage ="You must enter Description")]
        public string Description { get; set; }
    }
}
