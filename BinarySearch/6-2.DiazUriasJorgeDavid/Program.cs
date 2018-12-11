using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2.DiazUriasJorgeDavid
{
    class Program
    {
        static void Main(string[] args)
        {
            Busqueda1 P1 = new Busqueda1(); //Ejemplo 1
            P1.Captura();
            Busqueda2 P2 = new Busqueda2(); //Ejemplo 2
            P2.Captura();
            Console.ReadKey();
        }
    }
}
