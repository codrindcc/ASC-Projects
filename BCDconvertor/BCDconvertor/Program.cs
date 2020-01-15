using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDconvertor
{
    class Program
    {
        //convertor baze
        static void Main(string[] args)
        {        
            int[] v = new int[100];
            int i = 0;
            int n, b1, b;
         
            Console.Write("Scrieti numarul : ");
            string str = Console.ReadLine();
            Console.Write("Scrieti baza in care este numarul: ");
            b1 = int.Parse(Console.ReadLine());
            int nr2 = 0;

            bool ok = true;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    if ((str[i] - '0') >= b1)
                        ok = false;
                }
                else
                {
                    if ((str[i] - 55) >= b1)
                        ok = false;
                }
            }
            if (ok)
            {
                for (i = str.Length - 1; i >= 0; i--)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                        nr2 = nr2 + (str[i] - '0') * (int)Math.Pow(b1, str.Length - 1 - i);
                    else
                        nr2 = nr2 + (str[i] - 55) * (int)Math.Pow(b1, str.Length - 1 - i);
                }
               
                int b2;
                Console.Write("Scrieti baza finala : ");
                b2 = int.Parse(Console.ReadLine());
                int idx = 0;
                while (nr2 != 0)
                {
                    v[idx] = nr2 % b2;
                    idx++;
                    nr2 = nr2 / b2;
                }
                Console.WriteLine();
                for (int j = idx - 1; j >= 0; j--)
                {
                    if (v[j] < 10)
                        Console.Write("{0}", (int)v[j]);
                    else
                        Console.Write("{0}", (char)(v[j] + 55));
                }
            }
            else
                Console.Write("Baza nu este corecta ");
            Console.ReadKey();

        }
    }
}
