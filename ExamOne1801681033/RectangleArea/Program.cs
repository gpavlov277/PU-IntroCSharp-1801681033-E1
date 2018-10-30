using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double SideA = rand.Next(1, 130);
            double SideB = rand.Next(1, 200);

            double RectangleArea = SideA * SideB;
            Console.Write("Area is: ");
            Console.WriteLine(Math.Round(RectangleArea,2));
           // Console.WriteLine(SideA);
            //Console.WriteLine(SideB);


        }
    }
}
