using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Pizza
    {
        public string Nev { get; set; }
        public int Kicsi { get; set; }
        public int Nagy { get; set; }

        public Pizza(string sor)
        {
            string[] d = sor.Trim().Split(';');
            Nev = d[0];
            Kicsi = Convert.ToInt32(d[1]);
            Nagy = int.Parse(d[2]);
        }
    }
}
