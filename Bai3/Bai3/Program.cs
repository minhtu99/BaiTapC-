using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int ketqua;
            Console.WriteLine("Nhap mot so bat ky:");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
               
                Console.WriteLine(a + "*" + i + " = " + ketqua);
            }
            Console.ReadKey();

        }
    }
}
