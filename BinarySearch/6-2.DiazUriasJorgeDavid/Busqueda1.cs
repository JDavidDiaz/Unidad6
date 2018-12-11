using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2.DiazUriasJorgeDavid
{
    class Busqueda1
    {
        public void Captura()
        {
            Console.WriteLine("Ejemplo 1");
            Console.WriteLine("Ingrese la longitud del vector"); //Se le pide al usuario ingresar la longitud del vector
            int Longitud = int.Parse(Console.ReadLine());
            int[] Vector = new int[Longitud]; //Se inicializa el vector con la longitud ingresada
            for (int i = 0; i < Vector.Length; i++) //Capura de los elementos del vector
            {
                Console.Write("Ingrese elemento {0}: ", i + 1);
                Vector[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese el elemento que desea buscar"); //Pide al usuario el elemento a buscar
            int Objetivo = int.Parse(Console.ReadLine());
            Array.Sort(Vector); //Se ordena el arreglo de menor a mayor
            Busqueda(Objetivo, Vector); //Llama al metodo busqueda
            Imprimir(Vector); //Llama al metodo imprimir
        }

        public void Busqueda(int Num, int[] Vector) //Recibe como parametros el Numero a encontrar y el vector
        {
            int LimInferior = 0, LimSuperior = Vector.Length, Medio = 0; //Se inicializan variables
            bool found = false; 

            while (LimInferior <= LimSuperior && found == false) //Mientras LimIngerior sea menor o igual a LimSuperior y Found sea falso entonces
            {
                Medio = (LimInferior + LimSuperior) / 2; //Medio obtiene el valor de la suma de ambos limites entre 2
                if (Vector[Medio] == Num) //Si el vector con el indice medio es igual al numero a encontrar entonces
                {
                    found = true; //Se encontro el numero
                }                   
                if (Vector[Medio] > Num) //Si es mayor al numero a encontrar entonces
                {
                    LimSuperior = Medio - 1; //LimSuperior obtiene el valor de medio -1
                }
                else //si no
                {
                    LimInferior = Medio + 1; //LimInferior obtiene el valor de medio +1
                }                  
            }
            if (found == false) //Si Found es falso entonces
            {
                Console.Write("\nEl elemento {0} no esta en el arreglo\n", Num); //El elemento no se encuentra en el arreglo
            }               
            else //Si es verdadero
            {
                Console.Write("\nEl elemento {0} esta en la posicion: {1}\n", Num, Medio + 1); //Obtiene el indice en donde se encuentra
            }
        }

        public void Imprimir(int[] Vector) //Impresion del vector
        {
            
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.Write(Vector[i] + "  ");
            }
        }
    }
}
