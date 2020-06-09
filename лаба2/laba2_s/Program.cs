using System;
using lib;

namespace laba2_s
{





    class Program
    {
        static void Main(string[] args)
        {


            Text skovoroda = new Text("Всякому мiсту — звичай i права,");
            skovoroda.Addstr("Всяка тримає свiй ум голова;");
            skovoroda.Addstr("Всякому серцю — любов i тепло,");
            skovoroda.Addstr("Всякеє горло свiй смак вiднайшло");

            skovoroda.OutText();

            Stroka Esenin_1 = new Stroka("не жалею, не зову, не плачу");
            Stroka Esenin_2 = new Stroka("Все пройдет, как с белых яблонь дым");

            skovoroda.Addstr(Esenin_1);
            skovoroda.OutText();

            skovoroda.Delstr(5);
            skovoroda.OutText();

            skovoroda.change('в', 'у');      //заміна українського символу на латинський*
            skovoroda.OutText();

            Console.WriteLine(skovoroda.Numberlet());
            Console.WriteLine("=============================================================================");

            skovoroda.Addstr("Всякому серцю — любов i тепло,");
            skovoroda.Addstr("Всякому серцю — любов i тепло,");

            skovoroda.OutText();
            Console.WriteLine(skovoroda.Find("Всякому серцю — любов i тепло,"));
            Console.WriteLine("=============================================================================");






            Console.ReadKey();

        }
    }
}
