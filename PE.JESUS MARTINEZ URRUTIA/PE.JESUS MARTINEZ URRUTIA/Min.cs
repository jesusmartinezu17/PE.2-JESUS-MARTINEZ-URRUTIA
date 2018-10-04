using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.JESUS_MARTINEZ_URRUTIA
{
    class Min
    {
         public  int Minimo (int x)
        {
            int[] Sucesion = new int[x];
            int min=1000000000;
            for (int i = 0; i < Sucesion.Length; i++)
                {
                Console.WriteLine("Ingresa un valor");
                Sucesion[i] = int.Parse(Console.ReadLine());
                int numer = Sucesion[i];

                    if (numer <= min)
                    {
                        min = numer;
                    }
                }
            return min;
        }
    }
}
