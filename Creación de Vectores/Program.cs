using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamañovectores;
            Console.WriteLine("Introduce el número total de vectores");
            tamañovectores = int.Parse(Console.ReadLine());
            string[] contenido  = new string [tamañovectores];
            int vector;
            for (int i = 0; i < tamañovectores; i++)
            {
                vector = i + 1;
                Console.WriteLine("Introduce el contenido para el vector: " + vector);
                contenido[i] = Console.ReadLine();
            }
            int indice = 0;
            foreach (string item in contenido)
            {
                Console.WriteLine("Vector " + (indice + 1) + ": " + contenido[indice] + " ");
                indice++;
            }
            Console.ReadKey();
        }
    }
}
