using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.WebUI.Areas.Admin.Models
{
    public class PriorityAddViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Desription")]
        [Required(ErrorMessage ="You must enter description")]
        public string Description { get; set; }
    }
}
