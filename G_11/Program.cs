using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberList numberList = new NumberList();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar número");
                Console.WriteLine("2. Ordenar de forma ascendente");
                Console.WriteLine("3. Ordenar de forma descendente");
                Console.WriteLine("4. Buscar un número");
                Console.WriteLine("5. Eliminar un número");
                Console.WriteLine("6. Mostrar lista");
                Console.WriteLine("7. Salir");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Ingrese el número a insertar: ");
                        int numberToAdd = int.Parse(Console.ReadLine());
                        numberList.AddNumber(numberToAdd);
                        break;
                    case "2":
                        Console.Clear();
                        numberList.SortAscending();
                        Console.WriteLine("Lista ordenada de forma ascendente.");
                        numberList.PrintNumbers();
                        break;
                    case "3":
                        Console.Clear();
                        numberList.SortDescending();
                        Console.WriteLine("Lista ordenada de forma descendente.");
                        numberList.PrintNumbers();
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Ingrese el número a buscar: ");
                        int numberToSearch = int.Parse(Console.ReadLine());
                        int index = numberList.SequentialSearch(numberToSearch);
                        if (index != -1)
                            Console.WriteLine($"Número encontrado en la posición {index}.");
                        else
                            Console.WriteLine("Número no encontrado.");
                        break;
                    case "5":
                        Console.Clear();
                        Console.Write("Ingrese el número a eliminar: ");
                        int numberToRemove = int.Parse(Console.ReadLine());
                        numberList.RemoveNumber(numberToRemove);
                        Console.WriteLine("Número eliminado. Lista actualizada:");
                        numberList.PrintNumbers();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Lista actual:");
                        numberList.PrintNumbers();
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.ReadKey();
            }
            
        }
    }
    
}
