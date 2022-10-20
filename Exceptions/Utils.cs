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
            catch (OverflowException e)
            {
                Console.WriteLine("Errore: " + e.Message);
                throw e;
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);
                throw e;
            }
        }
    }
}
