using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ObslugaBledow
{
    class Program
    {
        static void Main(string[] args)
        {

            string n = "3";
            int b = 0;

            int[] d = new int[2];

            try
            {
                int a = Convert.ToInt32(n);
                int c = a / b;
                d[2] = c;
            }
            catch (FormatException)
            {
                Console.WriteLine("podales niepoprawna liczbe");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("probujesz podzielic przez 0");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("probujesz uzupenic zbyt wiele liczb");
            }
            catch (Exception)
            {
                Console.WriteLine("Cos poszlo nie tak");
            }finally
            {
                // to ma sie wykonac zawsze , niewazne czy blad byl czy nie 
            }

            Console.ReadKey();
        }
    }
}
