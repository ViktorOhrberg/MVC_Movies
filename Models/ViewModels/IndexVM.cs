using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models.ViewModels
{
    public class IndexVM
    {
        [Display(Name = "ID: ")]
        [Range (1, 3, ErrorMessage = "Selected ID is out of range")]
        public int ID { get; set; }
    }
}
