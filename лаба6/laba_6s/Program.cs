using System;

namespace laba6s
{
    class Program
    {
        class variable
        {
            
            public double a { get; private set; }
            public double b { get; private set; }
          
            public double c { get; private set; }
          
            public double d { get; private set; }
            
            public double Res { get; private set; }
          
            public variable(double a, double b, double c, double d)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
            }
            public void calculate()
            {

                

               
                    try
                    {
                        if (d > 41) throw new Exception("подкоренное значение меньше нуля");

                        if ((Math.Sqrt(41 - d) - b * a + c) == 0) throw new DivideByZeroException ("Деление на ноль") ;


                        Res = (a * b / 4.0 - 1) / (Math.Sqrt(41 - d) - b * a + c);

                        Console.WriteLine(Res);
                    }

                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
              
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Kozak Ivan IC-92");

            variable[] arr = new variable[5];


            variable v1 = new variable(0, 2, 1, 60);
            variable v2 = new variable(1, 1, 0, 4);
            variable v3 = new variable(0, 0, 0, 41);
            variable v4 = new variable(2, 8, 12, 6);
            variable v5 = new variable(5, 6, 1, 7);

            v1.calculate();
            v2.calculate();
            v3.calculate();
            v4.calculate();
            v5.calculate();

            arr[0] = v1;
            arr[1] = v2;
            arr[2] = v3;
            arr[3] = v4;
            arr[4] = v5;

            


        }
    }
}
