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
        //1 - Capire dove nasce l'eccezione
        //2 - Capire quale eccezione viene lanciata
        //3 - Capire se quell'istruzione può sollevare l'eccezione
        //4 - Gestire le eccezioni (try, catch). Ogni eccezione il suo catch 
        //4.1 - Dove la gestisco 
        //4.2 - Come la gestisco (WriteLine del Tipo di errore)
        //5 - Commit
        //6 - Request
            byte num1 = 30;
            byte num2 = 60;

            try
            {
                int risultato = Utils.CalcolaRisultato(num1, num2);

                Console.WriteLine($"Il risultato è: {risultato}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
