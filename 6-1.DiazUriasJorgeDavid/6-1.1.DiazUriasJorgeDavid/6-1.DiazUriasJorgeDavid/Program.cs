using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1.DiazUriasJorgeDavid
{
    namespace Tipos_de_Busquedas
    {
        class Program
        {
            static void Main(string[] args)
            {
                Busqueda Search = new Busqueda(); //Se instancia la clase Busqueda
                Search.Captura(); //Se llama al metodo para Capturar Datos
                Console.ReadLine();
            }
        }
    }
}
