using System;
using System.Runtime.CompilerServices;

namespace Lab7
{
    public class Node
    {
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public double Value { get; set; }

        public Node() { }
    }
    public class CustomList
    {
        public Node Head;
        public Node Tail;
        public int Length = 0;

        public CustomList(double[] data)
        {
            if (data.Length != 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Insert(data[i]);
                }
            }
        }

        public double this[int a]
        {
            get
            {
                int b = 0;
                Node temp = Head;
                while (b != a)
                {
                    temp = temp.Next;
                    b++;
                }

                return temp.Value;
            }
            set
            {
                int b = 0;
                Node temp = Head;
                while (b != a)
                {
                    temp = temp.Next;
                    b++;
                }

                temp.Value = value;
            }
        }

        public void Insert(double val)
        {
            Node temp = new Node();
            temp.Value = val;
            if (Head == null)
            {
                Head = temp;
                Tail = temp;
            }
            else
            {
                temp.Previous = Tail;
                Tail.Next = temp;
                Tail = temp;
            }

            Length++;
        }

        private double FindMean()
        {
            double s = 0;
            int n = 0;
            Node temp = Head;
            while (temp != null)
            {
                s += temp.Value;
                n++;
                temp = temp.Next;
            }

            double res = s / n;
            return res;
        }

        public int FindElementsLess()
        {
            Node temp = Head;
            int res = 0;
            double mean = FindMean();
            while (temp != null)
            {
                if (temp.Value < mean) { res++; }

                temp = temp.Next;
            }

            return res;
        }

        public void Print()
        {
            Node temp = Head;
            double[] arr = new double[Length];
            int i = 0;
            while (temp != null)
            {
                arr[i] = temp.Value;
                i++;
                temp = temp.Next;
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        private double FindMax()
        {
            Node temp = Head;
            double max = temp.Value;
            while (temp != null)
            {
                if (temp.Value > max)
                {
                    max = temp.Value;
                }

                temp = temp.Next;
            }

            return max;
        }

        public void DelElementsAfterMax()
        {
            double max = FindMax();
            while (Tail.Value != max)
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
                Length--;
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomList testList = new CustomList(new double[] { 1.0, 6.0, 5.0, 9.0, 4.0, 7.0, 8.0, 3.0 });
            testList.Print();
            Console.WriteLine(testList.FindElementsLess());
            testList.DelElementsAfterMax();
            testList.Print();
        }
    }
}