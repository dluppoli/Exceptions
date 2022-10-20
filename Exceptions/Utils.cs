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
            byte risultato = 0;

            try 
            { 
                risultato =  Convert.ToByte(num1 * num2);
            }
            catch(System.OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return risultato;



        }


    }
}
