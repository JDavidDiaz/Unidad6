using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1._2.DiazUriasJorgeDavid
{
    class Search
    {
        public int SqtBusqueda(int[] Vector, int NumeroABuscar)
        {
            Vector[Vector.Length - 1] = NumeroABuscar; //El penultimo valor del vector sera igual al Numero a buscar
            int i;
            for (i = 0; Vector[i] != NumeroABuscar; i++) ; //Si el valor del vector de la posicion i es diferente al numero a buscar entonces
            return (i < Vector.Length - 1) ? i : -1; //Se evalua la expresion segun el resultado de la condicion 
        }

        public void Captura()
        {
            int Cantidad;
            Console.WriteLine("Ingrese la longitud del vector");
            Cantidad = int.Parse(Console.ReadLine()); //Longitud del vector
            int[] Vector = new int[Cantidad];
            for (int i = 0; i < Cantidad; i++) //Captura de datos para el vector
            {
                Console.WriteLine("Ingrese el elemento {0}", i + 1);
                Vector[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\nIngrese el valor que desea buscar dentro de la lista"); 
            int Objetivo = int.Parse(Console.ReadLine()); //Numero a buscar en el vector
            int Posicion = SqtBusqueda(Vector, Objetivo) + 1; //El valor de la posicion sera el valor retornado por el metodo de busqueda
            Console.WriteLine("El elemento encontrado esta en la posicion: " + Posicion.ToString()); //Impresion de la posicion
            //Si el elemento a buscar no se encuentra imprimira un 0 (posicion 0 = no se encuentra)
        }
    }
}
