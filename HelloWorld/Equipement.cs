using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    public enum TypeEquipement
    {
        Epee,
        Armure,
        Bouclier,
    }

    public class Equipement
    {
        public string Nom { get; set; }

        public TypeEquipement Type { get; set; }

        public ConsoleColor Color { get; set; }
    }
}

