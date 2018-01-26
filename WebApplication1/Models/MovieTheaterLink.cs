using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MovieTheaterLink
    {
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        public int TheaterID { get; set; }
        public Theater Theater { get; set; }
    }
}
