using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Opeator
    {
        public void LogicalNegationOperator()
        {
            bool passed = false;
            Console.WriteLine(!passed);  // output: True
            Console.WriteLine(!true);    // output: False
        }

        public void LogicalANDOperator()
        {
            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool a = false & SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluated.
            // False

            bool b = true & SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True
        }

        public void LogicalExclusiveOROperator()
        {
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False
        }

        public void LogicalOROperator()
        {
            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool a = true | SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluated.
            // True

            bool b = false | SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True
        }
    }
}
