using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.JESUS_MARTINEZ_URRUTIA
{
    class Invert
    {
        public int invertido(int x)
        {
            int[] Sucesion = new int[x];
            int temporal = 0;
            for (int i = 0; i < Sucesion.Length; i++)
            {
                Sucesion[i] = int.Parse(Console.ReadLine());
                temporal = Sucesion[i];
                Sucesion[i] = Sucesion[Sucesion.Length - i - 1];
                Sucesion[Sucesion.Length - i - 1] = temporal;
            }
            for (int i = 0; i < Sucesion.Length; i++)
            {
                Console.WriteLine(Sucesion[i]);
            }
                return temporal;
        }
    }
}
