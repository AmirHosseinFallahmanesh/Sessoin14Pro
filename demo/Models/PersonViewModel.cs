using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace demo.Models
{
    public class PersonViewModel
    {
        public string Name { get; set; }
        public List<SelectListItem> HobbieList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "sport", Text = "ورزش" },
            new SelectListItem { Value = "study", Text = "مطاله ازاد" },
            new SelectListItem { Value = "movie", Text = "فیلم"    },
            new SelectListItem { Value = "serial", Text = "سریال" },
     
         };

        public IEnumerable<string> SelectedHobbies { get; set; }
    }
}

