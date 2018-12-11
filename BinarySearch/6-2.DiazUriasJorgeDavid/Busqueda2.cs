using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2.DiazUriasJorgeDavid
{
    class Busqueda2
    {
        public void Captura()
        {
            string[] Abecedario = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", 
            "r", "s", "t", "u", "v", "w", "x", "y", "z" }; //Arreglo de letras del abecedario
            Console.WriteLine("\n\nEjemplo2\nIngrese la letra del abecedario que desee saber su posicion"); //Pregunta al usuario la letra a buscar
            string Letra = Console.ReadLine();
            int index1 = Array.BinarySearch(Abecedario, Letra); //Se ejecuta el metodo BinarySearch que tienen las listas como metodo predeterminado y se envia como parametro el arreglo y la letra a buscar
            Console.WriteLine("\nLa letra {1} se encuentra en la posicion {0}", index1, Letra); //Imprime la posicion
            int i = 0;
            foreach (var item in Abecedario) //Muestra la lista de las letras del abecedario
            {
                Console.WriteLine("{0}: {1}", i++, item);
            }
        }
    }
}
