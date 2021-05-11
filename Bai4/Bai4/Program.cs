using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gia tri trung binh la: ");
            int a, b, c, d;
            int ketqua;
            Console.WriteLine(" nhap gia tri a:");
            Console.WriteLine(" nhap gia tri b:");
            Console.WriteLine(" nhap gia tri c:");
            Console.WriteLine(" nhap gia tri d:");


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            ketqua = (a + b + c + d) / 4;

            Console.WriteLine(((a + "+" + b + "+" + c + "+" + d)+ "/" +4) + "=" + ketqua );
            Console.ReadKey();


        }
    }
}
