using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ObslugaBledow
{
    class Program
    {
        static void Main(string[] args)
        {
            string liczba = "h";

            int? a =null;

            try
            {
                a = Convert.ToInt32(liczba);
            }
            catch (Exception)
            {
                Console.WriteLine("niepoprawna konwersja");
            }


            if (a != null)
            {
                a++;
                Console.WriteLine(a);
            }
            


            Console.ReadKey();


        }
    }
}
