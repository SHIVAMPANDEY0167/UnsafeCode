using System;

namespace unsafe1
{
    class Program
{
    static void Main(string[] args)
    {
            
            
            int num1;
            unsafe
            {
                Console.WriteLine("Enter the number to check odd or even");
                num1 = int.Parse(Console.ReadLine());
                int* ptr;
                ptr = &num1;
                if (*ptr % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
                Console.ReadKey();
            }
            

     }
}
}
