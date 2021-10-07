using System;

namespace OperatorOverloadingfHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5,10);
            Rectangle r2 = new Rectangle(1, 3);
            Square s1 = new Square(5);
            Square s2 = new Square(5);

            r1++;
            r1 *= 2;
            r1 += r2;
            Console.WriteLine($"Is r1=r2: {r1.Equals(r2)}");
            r1.Print();

            Console.WriteLine($"Is s1=s2: {s1.Equals(s2)}\nSquare area: {s1.Area}");
            s1++;
            s1 *= 2;
            s1 += s2;
            s1.Print();
            

        }
    }
}
