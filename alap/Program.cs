using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alap
{
    class Program
    {
        static int[] RandomTombLetrehoz(int n)
        {
            if (n < 1)
                return null;

            Random random = new Random();
            int[] tomb = new int[n];
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = random.Next();
            return tomb;
        }

        static int[] RandomTombLetrehoz(int n, int max)
        {
            if (n < 1)
                return null;

            Random random = new Random();
            int[] tomb = new int[n];
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = random.Next(max);
            return tomb;
        }

        static int[] RandomTombLetrehoz(int n, int min, int max)
        {
            if (n < 1)
                return null;

            Random random = new Random();
            int[] tomb = new int[n];
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = random.Next(min, max);
            return tomb;
        }

        static void TombKiir(int[] tomb)
        {
            if (tomb == null)
            {
                Console.WriteLine("null tömböt kaptam!");
                return;
            }

            foreach (int elem in tomb)
                Console.Write(elem + " ");
            Console.Write("\n");
        }

        static int[] TombLetrehozSzam(int n, int szam)
        {
            if (n < 1)
                return null;

            int[] tomb = new int[n];
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = szam;
            return tomb;
        }

        static int[] TombLetrehozNovekvo(int n, int kezdo = 1)
        {
            if (n < 1)
                return null;

            int[] tomb = new int[n];
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = i + kezdo;
            return tomb;
        }

        static int[] TombLetrehozFibonacci(int n)
        {
            if (n < 1)
                return null;

            int[] tomb = new int[n];
            tomb[0] = 1;
            if (n == 1)
                return tomb;
            tomb[1] = 1;
            for (int i = 2; i < tomb.Length; i++)
            {
                tomb[i] = tomb[i - 1] + tomb[i - 2];
            }
            return tomb;
        }

        static void Main(string[] args)
        {
            int[] t1 = RandomTombLetrehoz(10, 10, 101);
            int[] t2 = RandomTombLetrehoz(100);
            int[] t3 = TombLetrehozNovekvo(5);
            int[] t4 = TombLetrehozNovekvo(5, 1);
            int[] t5 = TombLetrehozNovekvo(5, 10);

            int[] fib = TombLetrehozFibonacci(0);
            Console.WriteLine("fib:");
            TombKiir(fib);

            Console.ReadKey();
        }
    }
}
