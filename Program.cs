using System;

namespace sattestfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ1
            int n = 0 - 9;
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine());
            int n8 = int.Parse(Console.ReadLine());
            int n9 = int.Parse(Console.ReadLine());
            int a = 1 - 9;
            int a10 = int.Parse(Console.ReadLine());
            
            if (n1 == a10||n2==a10||n3==a10||n4==a10||n5==a10||n6==a10||n7==a10||n8==a10||n9==a10)
            {
                Console.WriteLine("{0} {1} {2}", n1, n2, n3);
                Console.WriteLine("{0} {1} {2}", n4, n5, n6);
                Console.WriteLine("{0} {1} {2}", n7, n8, n9);
                Console.WriteLine();
                Console.WriteLine("The number is available");
            }
            else 
            {
                Console.WriteLine("{0} {1} {2}",n1,n2,n3);
                Console.WriteLine("{0} {1} {2}",n4,n5,n6);
                Console.WriteLine("{0} {1} {2}",n7,n8,n9);
                Console.WriteLine();
                Console.WriteLine("{0} {1} {2}", n1, n2, n3);
                Console.WriteLine("{0} {1} {2}", n4, n5, n6);
                Console.WriteLine("{0} {1} {2}", n7, a10, n9);
            }
            Console.ReadLine();


        }
    }
}
