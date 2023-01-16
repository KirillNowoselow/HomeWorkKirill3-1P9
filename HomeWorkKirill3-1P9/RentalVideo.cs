using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    abstract class RentalVideo
    {
        public Movie Movie { get; set; }
        public MediaType MediaType { get; set; }
    }
}
