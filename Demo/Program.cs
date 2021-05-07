using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] polje;
            int[] poljeIntova = new int[] { 1, 2, 3, 4, 5 };
            int[] poljeIntova2 = new int[] { 7, 9 };

            //IspisPolja(poljeIntova);
            //IspisPolja(poljeIntova2);
            //IspisPolja(poljeIntova);

            int rezultat = Umnozak(1,1);
            Console.WriteLine(rezultat);
            Console.WriteLine(Umnozak(2,3));
            IspisPoruke();
            Console.WriteLine(NajveciInteger());
        }

        static void IspisPolja(int[] polje)
        {
            for (int i = 0; i < polje.Length; i++)
            {
                Console.WriteLine(polje[i]);
            }
        }

        static int Umnozak(int a,int b)
        {
            return a * b;
        }

        static void IspisPoruke()
        {
            Console.WriteLine("Bok!");
        }

        static int NajveciInteger()
        {
            return int.MaxValue;
        }

         
    }
}
