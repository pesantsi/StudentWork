using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Hero monHero = new Hero();
            monHero.Nom = "Antoine";
            monHero.PointDeVie = 10;
            monHero.Inventaire = new List<Equipement>();
            monHero.Inventaire.Add(new Equipement() { Color = ConsoleColor.Blue, Nom = "Super Power Armure", Type = TypeEquipement.Armure });
            monHero.Inventaire.Add(new Equipement() { Color = ConsoleColor.White, Nom = "epee draconics", Type = TypeEquipement.Epee });
            monHero.Inventaire.Add(new Equipement() { Color = ConsoleColor.Green, Nom = "bouclier", Type = TypeEquipement.Bouclier });

            Histoire histoireDeMonHero = new Histoire();
            histoireDeMonHero.Introduction();

            //écoute la console pour une clé de l'utilisateur
            Console.ReadKey();
        }
    }
}
