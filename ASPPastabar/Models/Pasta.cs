using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPastabar.Models
{
    public class Pasta
    {
        public int Id { get; set; }
        public Soort Soort { get; set; }
        public Grootte Grootte { get; set; }
        public Saus Saus { get; set; }
    }
}
