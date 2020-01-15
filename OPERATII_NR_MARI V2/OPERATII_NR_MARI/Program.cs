using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATII_NR_MARI
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERATII CU NR MARI

            int[] v1 = new int[] { 3, 4, 4, 3, 3, 2, 1, 1, 1, 3, 4, 4, 6, 5, 5, 4, 3, 2, 3, 4, 4, 3, 3, 2, 1, 1, 1, 3, 4, 4, 6, 5, 5, 4, 3, 2, 3, 4, 4, 3, 3, 2, 1, 1, 1, 3, 4, 4, 6, 5, 5, 4, 3, 2, 3, 4, 4, 3, 3, 2, 1, 1, 1, 3, 4, 4, 6, 5, 5, 4, 3, 2 };
            int[] v2 = new int[] { 9, 1, 1, 2, 3, 2, 2, 1, 2, 3, 4, 8, 8, 6, 2, 1, 1, 1, 3, 4, 4, 3, 3, 2, 1, 1, 1, 3, 4, 4, 6, 5, 5, 4, 3, 2, 3, 4, 4, 3, 3, 2, 1, 1, 1, 3, 4, 4, 6, 5, 5, 4, 3, 2, 3, 4, 4, 3, 3, 2, 1, 1, 1, 3, 4, 4, 6, 5, 5, 4, 3, 2, 3, 4, 4, 3, 3, 2, 1, 1, 1, 3, 4, 4, 6, 5, 5, 4, 3, 2 };

            for (int i = 0; i < v1.Length; i++)
                Console.Write(v1[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < v2.Length; i++)
                Console.Write(v2[i] + " ");
            Console.WriteLine();

            for (int i = 0; i < v1.Length / 2; i++)
            {
                int aux = v1[i];
                v1[i] = v1[v1.Length - 1 - i];
                v1[v1.Length - 1 - i] = aux;
            }

            for (int i = 0; i < v2.Length / 2; i++)
            {
                int aux = v2[i];
                v2[i] = v2[v2.Length - 1 - i];
                v2[v2.Length - 1 - i] = aux;
            }

            int n1 = v1.Length;
            int n2 = v2.Length;

            int max = n1;
            if (n2 > n1) max = n2;

            int[] v3 = new int[max];
            int k1 = 0;
            int k3 = 0;


            int t = 0;
            while (k1 < n1 && k1 < n2)
            {
                v3[k3] = (v1[k1] + v2[k1] + t) % 10;
                t = (v1[k1] + v2[k1] + t) / 10;
                k1++;
                k3++;
            }

            while (k1 < n1)
            {
                v3[k3] = (v1[k1] + t) % 10;
                t = (v1[k1] + t) / 10;
                k1++;
                k3++;

            }
            while (k1 < n2)
            {
                v3[k3] = (v2[k1] + t) % 10;
                t = (v2[k1] + t) / 10;
                k1++;
                k3++;

            }

            if (t != 0)
            {
                int[] v4 = new int[max + 1];
                for (int i = 0; i < max; i++)
                    v4[i] = v3[i];
                v4[max] = t;
                v3 = v4;
            }

            for (int i = 0; i < v3.Length / 2; i++)
            {
                int aux = v3[i];
                v3[i] = v3[v3.Length - 1 - i];
                v3[v3.Length - 1 - i] = aux;
            }


            for (int i = 0; i < v1.Length; i++)
                Console.Write(v1[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < v2.Length; i++)
                Console.Write(v2[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < v3.Length; i++)
                Console.Write(v3[i] + " ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
