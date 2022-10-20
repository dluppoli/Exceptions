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
            //Davide Regnani
            byte num1 = 30;
            byte num2 = 60;


            try
            {
                int risultato = Utils.CalcolaRisultato(num1, num2);
                Console.WriteLine($"Il risultato è: {risultato}");
            }
            catch (Exception e)
            {
                Console.WriteLine(" L'elaborazione non può proseguire a causa dell'errore");
            }
            finally
            {
                Console.ReadLine();
            }    
            
        }
    }
}
