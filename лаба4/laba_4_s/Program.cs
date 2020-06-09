using System;
using System.Threading;

class Dot
{
    public double x { get; set; }
    public double y { get; set; }
public Dot()
    {
        x = 0;
        y = 0;
    }

    public Dot(double value_x, double value_y)
    {
        x = value_x;
        y = value_y;
    }


    public static Dot operator +(Dot a, Dot b)
    {
        return new Dot(a.x + b.x, a.y + b.y);
    }

    public static Dot operator *(Dot a, double i)
    {
        return new Dot(a.x * i, a.y * i);
    }

}

class Triangle
{
    private Dot A, B, C;

    public Triangle()
    {
        A = new Dot(0, 0);
        B = new Dot(0, 0);
        C = new Dot(0, 0);
    }

    public Triangle(double ax, double ay, double bx, double by, double cx, double cy)
    {
        A = new Dot(ax, ay);
        B = new Dot(bx, by);
        C = new Dot(cx, cy);
    }

    public Triangle(Dot a, Dot b, Dot c)
    {
        A = a;
        B = b;
        C = c;
    }

    public Triangle(Triangle ABC)
    {
        this.A = ABC.A;
        this.B = ABC.B;
        this.C = ABC.C;
    }

   private double Storona (Dot A, Dot B)
    {
        double AB;
        AB = Math.Sqrt( Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2));

        return AB;

    }



    public double Perim()
    {

        return Storona(A, B) + Storona(A, C) + Storona(C, B);

    }


    public double Square()
    {
        double S, p= Perim()/2;



        S = Math.Sqrt(p * (p - Storona(A, B))* (p - Storona(A, C))* (p - Storona(C, B)));

        return S;
    }


    public static Triangle operator +( Triangle t1, Triangle t2)
    {

        return new Triangle(t1.A + t2.A, t1.B + t2.B, t1.C + t2.C);

    }


    public static Triangle operator *(Triangle t1, double i)
    {

        return new Triangle(t1.A * i, t1.B * i, t1.C * i);

    }


    public string Out ()
    {
        return $"({A.x};{A.y});({B.x};{B.y});({C.x};{C.y});";
    }

}





namespace laba_4_s
{
    class Program
    {
        static void Main(string[] args)
        {

            Dot A = new Dot();
            Dot B = new Dot(1, 0);
            Dot C = new Dot(0, 1);



            Triangle T1 = new Triangle(A, B, C);

            Triangle T2 = new Triangle(0, 0, 3, 0, 0, 4);

            Triangle T3 = new Triangle(A, B, new Dot (2, 1));

            Console.WriteLine("Kozak Ivan IC-92 \n\n");
            Console.WriteLine("T1:" + T1.Out());
            Console.WriteLine("T2:" + T2.Out());
            Console.WriteLine("T3:" + T3.Out());
            T3 = T3 * 2;

            T1 = T3 + T2;
          
            Console.WriteLine("===========================================================================");
            Console.WriteLine("T1:" + T1.Out());
            Console.WriteLine("T2:" + T2.Out());
            Console.WriteLine("T3:" + T3.Out());

            Console.WriteLine("P(T1) = "+ T1.Perim());
            Console.WriteLine("S(T1) = "+ T1.Square());


        }
    }
}
