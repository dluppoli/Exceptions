using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class Utils
    {
        internal static byte CalcolaRisultato(byte num1, byte num2)
        {
            try
            {
               
               return Convert.ToByte(num1 * num2);
               
            }
            catch (OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Valore troppo grande o troppo piccolo per un Unsigned Byte, Valore massimo: " + byte.MaxValue);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            return 0;   
        }
    }
}
