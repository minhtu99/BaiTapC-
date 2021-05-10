using System;
//Tráo đổi giá trị hai số: nhập vào 2 số nguyên bất kỳ,
//in ra màn hình giá trị ngược lại của 2 biến dó
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("nhap gia tri cua a:");
            string st = Console.ReadLine();
            a = Int32.Parse(st);

            Console.Write("nhap gia tri cua b:");
            string st1 = Console.ReadLine();
            b = Int32.Parse(st1);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("gia tri cua a la:" + a);
            Console.WriteLine("gia tri cua b la:" + b);

            Console.ReadKey();





        }
    }
}
