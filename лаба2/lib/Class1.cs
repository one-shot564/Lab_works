using System;
using System.Collections.Generic;


namespace lib
{
    public class Stroka
    {
        private string str;

        public Stroka(string strochka)
        {
            str = strochka;
        }

        public string Getstr()
        {
            return str;
        }

        public int Length()
        {
            return str.Length;
        }

        public void Change(char a, char b)
        {
            str = str.Replace(a, b);
        }

    }

    public class Text
    {
        private List<Stroka> text;


        public Text(Stroka str)
        {
            text = new List<Stroka> { str };
        }
        public Text(string str)
        {

            text = new List<Stroka> { new Stroka(str) };
        }


        public void Addstr(Stroka str)
        {
            text.Add(str);
        }

        public void Addstr(string str)
        {
            text.Add(new Stroka(str));
        }




        public void Delstr(int number)
        {
            text.RemoveAt(number - 1);
        }

        public void Clear()
        {
            text.Clear();
        }


        public int lengthStroka(int i)
        {
            return text[i].Getstr().Length;
        }

        public int Numberlet()
        {
            int number = 0;
            for (int i = 0; i < text.Count; i++)
            {
                number += lengthStroka(i);
            }

            return number;
        }

        public int Find(string strtofind)
        {
            int count = 0;
            for (int i = 0; i < text.Count; i++)
            {
                if (strtofind == text[i].Getstr()) count++;
            }

            return count;
        }

        public void change(char a, char b)
        {
            for (int i = 0; i < text.Count; i++)
            {
                text[i].Change(a, b);

            }
        }

        public void OutText()
        {
            for (int i = 0; i < text.Count; i++)
            {

                Console.WriteLine(text[i].Getstr());
            }
            Console.WriteLine("=============================================================================");

        }



    }

}
