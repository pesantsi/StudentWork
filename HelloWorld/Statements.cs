using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Statements
    {
        #region Selection

        public void SelectionStatements()
        {
            bool heroEstVivant = true;

            //si le hero est vivant
            if(heroEstVivant)
            {
                //ceci sera exécuté
                Console.WriteLine("Le hero est vivant");
            }
            else
            {
                //si le hero est mort, ceci sera executé
                Console.WriteLine("Le hero est mort");
            }


            int quantitéDeVie = 100;

            switch(quantitéDeVie)
            {
                case 100:
                    //si le hero à plein de vie, ceci sera executé
                    Console.WriteLine("Je suis plein d'énergie");
                    break;

                case 50:
                    //si le hero est à la moitié de vie, ceci sera executé
                    Console.WriteLine("Je suis blessé");
                    break;

                case 10:
                    //si le hero est à 10 de vie, ceci sera executé
                    Console.WriteLine("Je suis presque mort");
                    break;

                default:
                    Console.WriteLine("J'ai mal");
                    //dans tout le reste des case, ceci sera executé
                    break;
            }
        }

        #endregion

        #region Iteration statements

        public void IterationStatements()
        {
            int n = 0;
            do // Fait tant que n < 5
            {
                Console.WriteLine(n);
                n++;
            } while (n < 5);


            // tant que i < 5 execute le code
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 5) // si j < 5 execute de code
            {
                Console.WriteLine(n);
                j++;
            }
        }

        #endregion
    }
}
