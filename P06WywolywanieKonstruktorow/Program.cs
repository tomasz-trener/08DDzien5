using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06WywolywanieKonstruktorow
{
    class Program
    {
        static void Main(string[] args)
        {

            Czlowiek c = new Czlowiek("Kowalski");

            Czlowiek c2 = new Czlowiek("Jan", "Kowalski");
        }
    }
}
