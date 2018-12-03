using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1.DiazUriasJorgeDavid
{
    class Busqueda
    {
        public int BusquedaSecuencial(int[] Vector, int Objetivo, int Cantidad) //Recibe como parametros el Vector, el numero a buscar y la longitud del vector
        {
            int Buscar = 0;
            int i;
            int Posicion = -1;
            for (i = 0; i < Cantidad && Buscar != 1; i++) //Si i es menor a (cantidad y buscar diferentes a 1) entonces
            {
                if (Objetivo == Vector[i]) //Si el numero a buscar se encuentra en el vector entonces
                {
                    Posicion = i; //La posicion sera igual a el valor de i
                    Buscar = 1;  //El valor de Buscar sera igual a 1
                }
            }
            return Posicion; //Retorna la posicion del numero
        }

        public void Captura()
        {
            int Cantidad;
            Console.WriteLine("Ingrese la longitud del vector");
            Cantidad = int.Parse(Console.ReadLine()); //Longitud del vector
            int[] Vector = new int[Cantidad]; //Vector desordenado
            for (int i = 0; i < Cantidad; i++) //Captura de datos por el usuario
            {
                Console.WriteLine("Ingrese numero {0}", i + 1);
                Vector[i] = int.Parse(Console.ReadLine());
            }
            int Posicion;
            Console.WriteLine("\n\nIngrese el numero que desea buscar");
            int Objetivo = int.Parse(Console.ReadLine()); //Numero por buscar en la lista
            Posicion = BusquedaSecuencial(Vector, Objetivo, Cantidad); //Guarda el valor retornado por el metodo de Busqueda
            if (Posicion != -1) //Si Posicion es diferente a -1 entonces
            {
                Console.WriteLine("El numero ha sido encontrado y esta en la posicion: {0}", Posicion + 1);
            }
            else //Si no entonces
            {
                Console.WriteLine("El elemento ingresado no se encuentra en la lista.\n");
            }              
        }
    }
}
