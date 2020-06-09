using System;

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

class Figure
{
    public Dot A, B, C, D;

    public Figure()
    {
        A = new Dot(0, 0);
        B = new Dot(0, 0);
        C = new Dot(0, 0);
        D = new Dot(0, 0);
    }

    public Figure(double ax, double ay, double bx, double by, double cx, double cy, double dx, double dy)
    {
        A = new Dot(ax, ay);
        B = new Dot(bx, by);
        C = new Dot(cx, cy);
        D = new Dot(dx, dy);
    }

    public Figure (Dot a, Dot b, Dot c, Dot d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public Figure(Figure ABCD)
    {
        this.A = ABCD.A;
        this.B = ABCD.B;
        this.C = ABCD.C;
        this.D = ABCD.D;
    }

    public double Storona(Dot A, Dot B)
    {
        double AB;
        AB = Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2));

        return AB;

    }

  
    public string Out()
    {
        return $"({A.x};{A.y});({B.x};{B.y});({C.x};{C.y});({D.x};{D.y});";
    }

}

class Square : Figure
{
    

    public Square(double ax, double ay, double bx, double by, double cx, double cy, double dx, double dy)
        :base(ax, ay, bx, by, cx, cy, dx, dy) { }


    public Square(Dot a, Dot b, Dot c, Dot d)
         : base(a, b, c, d) { }

        
     
   
    public double S()
    {
        return Math.Pow(Storona(A, B),2);
    }

    public double Perim()
    {
        return Storona(A, B)*4;
    }
}


namespace laba5_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Dot A = new Dot(1, 0);
            Dot B = new Dot(3, 0);
            Dot C = new Dot(3, 2);
            Dot D = new Dot(1, 2);

            Square ABCD = new Square(A, B, C, D);


            Console.WriteLine(ABCD.Out());
            Console.WriteLine($"Периметр = {ABCD.Perim()}");
            Console.WriteLine($"Площадь = {ABCD.S()}");

        }
    }
}
