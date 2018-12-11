using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud del vector"); //Pregunta al usuario la longitud del vector
            int Longitud = int.Parse(Console.ReadLine());
            MetodoHash hash = new MetodoHash(Longitud); //Instancia la clase MetodoHash y envia como parametro la Longitud
            int[] Elementos = new int[Longitud]; //Se inicializa un vector con la longitud ingresada
            for (int i = 0; i < Longitud; i++)
            {
                Console.WriteLine("Ingrese numero {0}", i + 1); //Captura de los elementos del vector
                Elementos[i] = int.Parse(Console.ReadLine());
            }
            hash.Funcion(Elementos, hash.Vector, Longitud); //Llama al metodo funcion
            hash.Imprimir(Longitud); //Llama al metodo imprimir
            Console.WriteLine("Ingrese el numero que desea buscar"); //Pregunta al usuario el numero que desea buscar
            int Objetivo = int.Parse(Console.ReadLine());
            int Buscar = hash.Busqueda(Objetivo, Longitud); //Llama al metodo Busqueda
            if (Buscar == 0) //Si buscar es igual a 0 entonces
            {
                Console.WriteLine("El elemento {0} no se encuentra en la tabla", Objetivo); //El numero no se encuentra
            }
            Console.ReadKey();
        }
    }
}
