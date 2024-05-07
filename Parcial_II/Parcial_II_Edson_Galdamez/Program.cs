using System;

namespace Parcial_II
{

class ArregloUnidimensional
{
    /* Realice un programa en lenguaje c# modo consola que permita lo siguiente:
* El programa debe solicitar el usuario el ingreso de 10 nombre y 10 valores numericos que respresentaran notas de un curso (ente 0 - 100)
* Utilizar arreglos para almacenar los datos
* Validar que los datos ingresados por el usuario sean del tipo correcto sino preguntar a usuario que ingrese de nuevo.
* Mostrar un menu con las siguientes opciones:
1) Mostrar nombre y nota de alumnos que aprobaron el curso.
2) Mostrar nombre y nota de alumnos que No aprobaron el curso.
3) Mostrar el promedio de notas del grupo.
4) Salir del programa

En su repositorio del curso crear un folder nombrado: Parcial_II, subir el proyecto completo. */
    private int[] lista;
    private int[] notas;
    public void Cargar()
    {
        lista = new int [10];

        for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese los nombres del alumno {i+1}: ");
                string nombre;
                nombre = Console.ReadLine();
                lista[i] = int.Parse(nombre);
            }
            notas = new int [10];

        for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese la nota de los alumnos {i+1}: ");
                string nota;
                nota = Console.ReadLine();
                notas[i] = int.Parse(nota);
            }
            
    }
    public void Imprimir()
        {
            
            bool salir = false;
            while(!salir)
            {
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                               * MENÚ *                                ║");
                Console.WriteLine("╠══════════════════════════════════╦════════════════════════════════════╣");
                Console.WriteLine("║   1. Mostrar alumons aprobados   ║   2. Mostrar alumnos no aprobados  ║");
                Console.WriteLine("╠══════════════════════════════════╬════════════════════════════════════╣");
                Console.WriteLine("║   3. Mostrar promedio            ║   4. Salir                         ║");
                Console.WriteLine("╚══════════════════════════════════╩════════════════════════════════════╝");
                 Console.Write("Selecciona la opcion a seguir:");

                string opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                    Console.WriteLine("");
                    Console.WriteLine($"Asi quedo tu lista de datos personales: ");
                    for (int i = 65; i < 101; i++)
                    {
                         Console.WriteLine($"{i +1}: {notas[i]}");
                    }
            Console.ReadKey();
                    break;
                    case "2":
                    
                    break;
                    case "3":
                    int suma = 0;
            foreach (int num in notas)
            {
                suma += num;
            }
            Console.WriteLine("El promedio de notas es "+ suma/10);
                    break;
                    case "4":
                    Console.WriteLine("Has elegido salir de la aplicacion");
                    salir = true;
                    break;
                    default:
                Console.WriteLine("La opcion seleccionada no es valida");
                break;
                }
            }
        }
    static void Main()
        {
            ArregloUnidimensional arregloUnidimensional_ = new ArregloUnidimensional();
            arregloUnidimensional_.Cargar();
            arregloUnidimensional_.Imprimir();
        }

}
}
