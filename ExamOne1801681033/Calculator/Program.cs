using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            char symbol = char.Parse(Console.ReadLine());
            double sum = 0.0;
            if (symbol == '+')
            {
                sum = (first + second);
                sum = sum / 0.1 + sum;

                Console.WriteLine($"Result is{sum}");
            }
           
        
            else if(symbol=='-')

            {



                if (first > second)
                    sum = Math.Sqrt(first*first)-second;
                else
                    sum = Math.Sqrt(second* second) - first;
                Console.WriteLine($"Result is {sum}");

      

            }

            else if (symbol == '*')

            {
                    sum = Math.Sqrt(second)*first;
                
                Console.WriteLine($"Result is {sum}");



            }

            else if (symbol == '/')

            {
                if (first == 0 || second == 0)
                    Console.WriteLine("Error Wrong input!");
                else

                    sum = first / second;

                Console.WriteLine($"Result is  {sum}");



            }



        }
    }
}
