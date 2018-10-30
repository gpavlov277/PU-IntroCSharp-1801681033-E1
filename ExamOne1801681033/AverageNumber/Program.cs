using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter");
            List<int> evenNUmber = new List<int>();
            bool isZero = false;
            while (!isZero)
            {
                Console.WriteLine("Emter a number");
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber == 0) break;
                if (currentNumber % 2 == 0) evenNUmber.Add(currentNumber);
            
                

            }
            if(evenNUmber.Count>0)
            {
                Console.WriteLine($"Total even numbers {evenNUmber.Count} Avg {evenNUmber.Average()}");
            }
            else
                Console.WriteLine("There aren`t avgs!");

        }
    }
}











//int sum = 0;
//int number = int.Parse(Console.ReadLine());
//            if (number >= 1 || number <= 255)
//                sum += number;
          
//            int Count = 0;
//bool isZero = false;
//            while (number< 1 || number> 255)
//            {
//                Console.WriteLine("Enter number between 1 and 255!");
//                number = int.Parse(Console.ReadLine());
//            }
//                while (number >= 1 || number <= 255)
//                {
//                    Console.WriteLine("Enter number:");
//                    number = int.Parse(Console.ReadLine());

//                    if (number % 2 == 0 && number!=0)
//                    {
//                        sum += number;
//                    Count++;
//                    isZero = true;
//                    }
                    
                
//                    if (number == 0)
//                        break;
              


//            }
//           if (isZero) Console.WriteLine($"Average = {sum / Count}");
//           else
//                Console.WriteLine("There are not even digits.");