using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3S
{
    class Massive
    {
        Random rnd = new Random();
        private char[,] arr = new char[10, 10];
        public char[,] Arr{get => arr; set => arr = value;}
        public Massive()
        {
            input();
        }

        public char index(int n, int m)
        {

            if (n <= 10 && m <= 10)
            {
                return Arr[n - 1, m - 1];
            }
            else
            {
                Console.WriteLine("ERROR");
                Console.WriteLine("write n: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("write m: ");
                m = Convert.ToInt32(Console.ReadLine());
                return index(n, m);
            }


        }


        public void input()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Arr[i, j] = (char)(rnd.Next(93) + 33);
                }
            }

        }

        public void Out()
        {
            for (int i = 0; i < 10; i++)
            {
                string str = "\0";

                for (int j = 0; j < 10; j++)
                {
                    str += Arr[i, j];
                    str += "\t";
                }
                Console.WriteLine(str);
            }

        }

        public string this [int number]
        {
            get
            {
                string str = "\0";
                if (number <= 10)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        str += Arr[j, number - 1];
                        str += "\t";
                    }
                }
               
                return str;
            }
        }



        public int number()
        {
            int nmb = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Char.IsDigit(Arr[i, j])) nmb++;
                }

            }
            return nmb;
        }


    }
    class Program

    {
        static void Main(string[] args)
        {

            Massive matrix = new Massive();

            matrix.Out();

            Console.WriteLine("==================================================================================");

            Console.WriteLine(matrix[7]);

            Console.WriteLine("цифр " + matrix.number());

            Console.ReadKey();
        }
    }
}