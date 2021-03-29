using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Hero
    {
        public string Nom { get; set; }

        public int PointDeVie { get; set; }

        public List<Equipement> Inventaire { get; set; }
    }
}
