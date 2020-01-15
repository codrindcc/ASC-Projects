using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_26._11
{
    class Program
    {
        //Bit pattern
        static void Main(string[] args)
        {
            uint n = 1u; //00...0001
            float f = (float)Math.Pow(2, 32);
            byte[] b;
            b = BitConverter.GetBytes(n);
            Console.WriteLine(BitConverter.IsLittleEndian);

            for (int i = b.Length - 1; i >= 0; i--)
            {          
                Console.Write($"{b[i].BitPattern()}");
            }
            Console.ReadKey();
        }
    }
}
