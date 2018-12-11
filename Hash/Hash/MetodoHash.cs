using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoHash
{
    class MetodoHash
    {
        public int[] Vector; //Inicializacion de variables
        int Tamaño;

        public MetodoHash(int T) //Constructor
        {
            Tamaño = T;
            Vector = new int[T];
            for (int i = 0; i < Vector.Length; i++) //Todos los elementos del vector seran igual a -1
            {
                Vector[i] = -1;
            }
        }

        public void Funcion(int[] Numeros, int[] Vector, int Long) //Recibe como parametros los numeros ingresados por el usuario, el vector de los elementos (-1) y la longitud
        {
            for (int i = 0; i < Numeros.Length; i++)
            {
                int Elemento = Numeros[i];
                int Indice = Elemento % (Long - 1); //Calcula el resto después de dividir su primer operando entre el segundo.
                Console.WriteLine("El indice es: {0} para el elemento {1}", Indice, Elemento);
                while (Vector[Indice] != -1) //Mientras el vector[indice] sea diferente a -1 entonces
                {
                    Indice++; //Incrementa el indice
                    Console.WriteLine("Ocurrio una colision en el indice {0} Cambiar al indice: {1}", Indice - 1, Indice);
                    Indice %= Tamaño; //Calcula el residuo 
                }
                Vector[Indice] = Elemento; //El vector[indice] obtiene el valor del elemento
            }
        }

        public void Imprimir(int Long)
        {
            int Incremento = 0, j; //Se inicializan variables
            for (int i = 0; i < 1; i++) //Impresion de tabla
            {
                Incremento += Long;
                for (j = 0; j < 71; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for (j = Incremento - Long; j < Incremento ; j++)
                {
                    Console.Write(string.Format("|  {0}" + " ", j));
                }
                Console.WriteLine("|");
                for (int n = 0; n < 71; n++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for (j = Incremento - Long; j < Incremento; j++)
                {
                    if (Vector[j].Equals("-1"))
                    {
                        Console.Write("|  ");
                    }
                    else
                    {
                        Console.Write(string.Format("| {0}" + " ", Vector[j]));
                    }
                }
                Console.WriteLine();
                for (j = 0;  j < 71; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }

        public int Busqueda(int Elemento, int Long) //Recibe como parametro el elemento a buscar y la longitud del vector
        {
            int Indice = Elemento % Long; //Calcula el residuo
            int Contador = 0;
            while (Vector[Indice] != -1) 
            {
                if (Vector[Indice] == Elemento) //Impresion del indice donde se encuentra el elemento solicitado
                {
                    Console.WriteLine("El elemento {0} Fue encontrado en el indice {1}", Elemento, Indice);
                    return Vector[Indice];
                }
                Indice++;
                Indice %= Tamaño;
                Contador++;
                if (Contador > Long) //Si el contador es mayor a la longitud entonces
                {
                    break; //Se acaba el ciclo
                }
            }
            return 0;
        }
    }
}
