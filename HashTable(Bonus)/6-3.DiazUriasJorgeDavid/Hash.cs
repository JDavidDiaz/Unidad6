using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3.DiazUriasJorgeDavid
{
    class Hash
    {
        public void Captura()
        {
            int NoControl; //Inicializacion de variables
            string Nombre;
            Console.WriteLine("Ingrese la cantidad de Alumnos"); //Se le pide al usuario la cantidad de alumnos
            int Cantidad = int.Parse(Console.ReadLine());
            Console.Clear();
            Hashtable Alumnos = new Hashtable(Cantidad); //Se crea un Hashtable con la cantidad de alumnos ingresados por el usuario
            while (true) //Se comienza el ciclo como verdadero
            {
                for (int i = 0; i < Cantidad; i++) //Ciclo para capturar a los alumnos dependiendo la cantidad 
                {              
                    Console.WriteLine("Ingrese numero de control y nombre del alumno {0}", i + 1); //Captura de los datos
                    Console.Write("No.Control: ");
                    NoControl = int.Parse(Console.ReadLine());
                    Console.Write("Nombre: ");
                    Nombre = Console.ReadLine();
                    if (Alumnos.Contains(NoControl)) //Si la coleccion ya contiene el Numero de control entonces
                    {
                        Console.WriteLine("No puede haber 2 alumnos con el mismo numero de control, ingrese uno diferente\n");
                        i = i - 1; //Se le resta 1 al contador del ciclo (for)
                        continue; //Se reinicia el ciclo (while) y vuelve a preguntar debido a que no puede haber 2 Numeros de control iguales
                    }              
                    Alumnos.Add(NoControl, Nombre); //Añade el numero de control y nombre del alumno respectivamente a la coleccion
                }
                Busqueda(Alumnos); //Manda a llamar el metodo de busqueda 
                break; //Se rompe el ciclo
            }               
        }

        public void Busqueda(Hashtable Alumnos) //Recibe como parametro la coleccion de alumnos
        {
            while (true) //Se comienza el ciclo como verdadero
            {
                Console.WriteLine("\n\nIngrese el No.Control del alumno a buscar"); //Pregunta al usuario el alumno que desea buscar
                int Objetivo = int.Parse(Console.ReadLine());
                if (Alumnos.ContainsKey(Objetivo)) //Si la coleccion contiene el numero de control ingresado entonces
                {
                    Console.WriteLine("\nEl Alumno con el numero de control: {0} es: {1}", Objetivo, Alumnos[Objetivo]); //Se imprime el alumno del numero de control ingresado
                    break; //Se termina el ciclo
                }
                else //si no entonces
                {
                    Console.WriteLine("\nNo se encuentra ningun alumno con el numero de control: {0}", Objetivo);
                    continue; //Vuelve a iniciar el ciclo y pregunta al usuario otro numero debido a que no se encontraba en la coleccion
                }
            }
            Console.WriteLine("\nLista de alumnos:");
            foreach (DictionaryEntry item in Alumnos) //Imprime la lista de todos los alumnos con sus respectivos numeros de control
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }
    }
}
