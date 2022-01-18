using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaZawodnicy.Errors
{
    public class NiepoprawnaSciezkaException : Exception
    {
        public NiepoprawnaSciezkaException(string tresc) :base(tresc)
        {
            
        }
    }
}
