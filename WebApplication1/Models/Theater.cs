using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Theater
    {
        public int TheaterID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Hours { get; set; }

        public ICollection<MovieTheaterLink> Movies { get; set; }
    }
}
