using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nicolò Govi
            byte num1 = 30;
            byte num2 = 6;
            

            
            if(Utils.CalcolaRisultato(num1, num2) != 0)
            {
                Console.WriteLine(Utils.CalcolaRisultato(num1, num2));
            }
            

            
            Console.ReadLine();
        }
    }
}
