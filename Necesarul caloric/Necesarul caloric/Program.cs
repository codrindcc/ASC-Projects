using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necesarul_caloric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti 0 daca sunteti femeie,respectiv 1 daca sunteti barbat: ");
            int gen =int.Parse(Console.ReadLine());

            //RMB Femei

            if (gen == 0)
            {
                Console.Write("Introduceti greutatea dvs. in KG: ");
                float greutate = float.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Introduceti inaltimea dvs. in cm: ");
                float inaltime = float.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Introduceti varsta dvs.: ");
                float varsta = float.Parse(Console.ReadLine());
                Console.WriteLine();

                float RMB = (float)655 + ((float)9.5 * greutate) + ((float)1.8 * inaltime) - ((float)4.7 * varsta);

                Console.WriteLine("Rata metabolismului bazal este: " + RMB);

                //Necesar caloric femei

                Console.WriteLine("daca esti sedentar apasa 1");
                Console.WriteLine("daca ai o activitate usoara apasa 2");
                Console.WriteLine("daca ai o activitate moderata apasa 3");
                Console.WriteLine("daca ai o activitate intensa apasa 4");
                Console.WriteLine("daca ai o activitate foarte intensa apasa 5");

                int activitate= int.Parse(Console.ReadLine());
                float nc;

                if(activitate==1)
                {
                    nc = RMB * (float)1.2;
                    Console.Write("Necesarul dvs. caloric este: " +nc );
                }

                if (activitate == 2)
                {
                    nc = RMB * (float)1.375;
                    Console.Write("Necesarul dvs. caloric este: " + nc);
                }
                if (activitate == 3)
                {
                    nc = RMB * (float)1.55;
                    Console.Write("Necesarul dvs. caloric este: " + nc);
                }
                if (activitate == 4)
                {
                    nc = RMB * (float)1.725;
                    Console.Write("Necesarul dvs. caloric este: " +nc );
                }
                if (activitate == 5)
                {
                    nc = RMB * (float)1.9;
                    Console.Write("Necesarul dvs. caloric este: " +nc );
                }

            }

            //RMB Barbati

            else
            {

                Console.Write("Introduceti greutatea dvs. in KG: ");
                float greutate1 = float.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Introduceti inaltimea dvs. in cm: ");
                float inaltime1 = float.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Introduceti varsta dvs.: ");
                float varsta1 = float.Parse(Console.ReadLine());
                Console.WriteLine();

                float RMB1 = (float)66 + ((float)13.7 * greutate1) + ((float)5 * inaltime1) - ((float)6.8 * varsta1);

                Console.WriteLine("Rata metabolismului bazal este: " + RMB1);
                
                
                //Necesar caloric barbati


                Console.WriteLine("daca esti sedentar apasa 1");
                Console.WriteLine("daca ai o activitate usoara apasa 2");
                Console.WriteLine("daca ai o activitate moderata apasa 3");
                Console.WriteLine("daca ai o activitate intensa apasa 4");
                Console.WriteLine("daca ai o activitate foarte intensa apasa 5");

                int activitate1= int.Parse(Console.ReadLine());
                float nc1;

                if (activitate1 == 1)
                {
                    nc1 = RMB1 * (float)1.2;
                    Console.Write("Necesarul dvs. caloric este: " + nc1);
                }

                if (activitate1 == 2)
                {
                    nc1 = RMB1 * (float)1.375;
                    Console.Write("Necesarul dvs. caloric este: " + nc1);
                }
                if (activitate1 == 3)
                {
                    nc1 = RMB1 * (float)1.55;
                    Console.Write("Necesarul dvs. caloric este: " + nc1);
                }
                if (activitate1 == 4)
                {
                    nc1 = RMB1 * (float)1.725;
                    Console.Write("Necesarul dvs. caloric este: " + nc1);
                }
                if (activitate1 == 5)
                {
                    nc1 = RMB1 * (float)1.9;
                    Console.Write("Necesarul dvs. caloric este: " + nc1);
                }
            }

            Console.ReadKey();


        }
    }
}
