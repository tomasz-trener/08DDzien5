using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ObslugaBledow
{
    class ManagerLiczb
    {
        public static int ZwiekszLiczbe(string napis)
        {
            int a;
            try
            {
                a = Convert.ToInt32(napis);
            }
            catch (Exception ex)
            {
                //throw new Exception("wystapił blad konwersji");
                throw ex;
            }
            finally
            {
                // zamykamy np polaczenia z baza, z innymi api , zwlaniamy obiekty pamieciozzerne 
            }


            string s = "ala ma kota";
            int b = s.Length;

            //if (a != null)
            a++;

            return a;
             
        }
    }
}
