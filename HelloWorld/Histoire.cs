using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Histoire
    {
        public void Introduction()
        {
            Console.WriteLine("Aujourd'hui vous allez en aprendre d'avantage sur l'histoire de se personnage.");
            Console.WriteLine("ecrire un texte");

            Console.WriteLine("Boom!!!!");

            Console.WriteLine("Un bruit est arrivé, que voulez-vous faire?");
            Console.WriteLine("1: Rester à la maison");
            Console.WriteLine("2: Sortir dehors pour ");


            var choixDuJoueur = Console.ReadKey();
            if (choixDuJoueur.Key == ConsoleKey.D1)
            {

            }
            else if (choixDuJoueur.Key == ConsoleKey.D2)
            { 

            }
        }
    }
}
