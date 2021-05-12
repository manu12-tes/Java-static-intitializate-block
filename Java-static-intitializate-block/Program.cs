using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_static_intitializate_block
{
    class Program
    {
        static int a = 3;
        static int b = 1;
        static bool bandera = false;

        static void cambiarBandera()
        {
            if (a > 0 || b> 0) { bandera = true; }
        }

        static void Main(string[] args)
          
        {
            cambiarBandera();
            if (bandera)
            {
                Console.WriteLine("El area es " + (a*b));
            }
            else
            {
                Console.WriteLine("Eroor no puedo procesar esta informacion ");
            }
        }
    }
}
