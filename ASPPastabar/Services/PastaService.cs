using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPPastabar.Models;

namespace ASPPastabar.Services
{
    public class PastaService
    {
            private List<Pasta> Bestellingen = new List<Pasta>();

            public void Add(Pasta b)
            {
                Bestellingen.Add(b);
            }

            public List<Pasta> ShowAll()
            {
                return Bestellingen;
            }


    }
}