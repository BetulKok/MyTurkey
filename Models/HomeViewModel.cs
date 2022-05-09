using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTurkey.Models
{
    public class HomeViewModel
    {
        public int? BolgeId { get; set; }
        public List<SelectListItem> Bolgeler { get; set; }

        public List<Sehir> Sehirler { get; set; }
    }
}
