using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.JESUS_MARTINEZ_URRUTIA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa cuántos números desea ingresar");
            int numeros = int.Parse(Console.ReadLine());
            Min Mins = new Min();
            Max Maxs = new Max();
            Invert Inverts = new Invert();
            Console.WriteLine(Mins.Minimo(numeros));
            Console.WriteLine();
            Console.WriteLine(Maxs.Maximo(numeros));
            Console.WriteLine();
            Console.WriteLine(Inverts.invertido(numeros));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
