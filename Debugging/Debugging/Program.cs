using System;

namespace Debugging
{
    class Program
    {
        static bool IsNumberFound(int myNumber,int compTries)
        {
            int left = 0;
            int right = 100;
            var command = "";
            while (true)
            {
                
                int mid = (left+right) / 2;
               
               
                if (compTries == 0)
                {
                    return false;
                }
                Console.WriteLine($"Is this your number: {mid}");
                Console.WriteLine("Nagore: Nadolu: Ok:");
                command = Console.ReadLine();
                if (command == "ok")
                {
                    return true;
                }
                else if (command == "nagore")
                {
                    left = mid+1;
                }
                else if (command == "nadolu")
                {
                    right = mid;
                }
                compTries--;

            }

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Моето Число");
            int myNumber = int.Parse(Console.ReadLine());
            if(myNumber>100)
            {
                Console.WriteLine("Chisloto trqbva da e pod 100");
                
            }
            else
            {
                Console.WriteLine("Computer tries");
                int compTries = int.Parse(Console.ReadLine());
                if (IsNumberFound(myNumber, compTries))
                {
                    Console.WriteLine("Kompyutura Specheli");
                }
                else
                {
                    Console.WriteLine("Ti Specheli");
                }
            }
            
        }
    }
}
