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
            byte num1 = 30;
            byte num2 = 60;

            int risultato = Utils.CalcolaRisultato(num1, num2);

            Console.WriteLine($"Il risultato è: {risultato}");
            Console.ReadLine();
        }
    }
}
