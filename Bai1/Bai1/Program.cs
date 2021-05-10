using System;
//	Tìm kết quả các phép toán cơ bản : + - * / %s
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = -1 + 4 * 6;
            b = (35 + 5) % 7;
            c = 14 + -4 * 6 / 11;
            d = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("gia tri cua a la: " + a);
            Console.WriteLine("gia tri cua b la: " + b);
            Console.WriteLine("gia tri cua c la: " + c);
            Console.WriteLine("gia tri cua d la: " + d);
            Console.ReadKey();

        }
    }
}
