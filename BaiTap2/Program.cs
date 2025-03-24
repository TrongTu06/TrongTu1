using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
     class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            string choice;
            do
            {
                Console.WriteLine("Nhap so nguyen N (he 10): ");
                int n = int.Parse(Console.ReadLine());
                int so = n;
                Console.WriteLine("Nhap he so X can chuyen doi (2, 8, 16): ");
                int x = int.Parse(Console.ReadLine());
                if (x == 2 || x == 8 || x == 16)
                {
                    while (n > 0)
                    {
                        stack.Push(n % x);
                        n = n / x;
                    }
                }
                else
                {
                    Console.WriteLine("He so khong hop le");
                    return;
                }
                string kq = "";
                string dinhdangcua16 = "0123456789ABCDEF";
                while (!stack.IsEmpty())
                {
                    int a = stack.Pop();
                    if (x == 16)
                    {
                        kq += dinhdangcua16[a];
                    }
                    else
                    {
                        kq += a;
                    }
                }
                Console.WriteLine($"So {so} chuyen sang {x} la: {kq}");
                Console.WriteLine("Tiep tuc khong? (Y/N");
                choice = Console.ReadLine();
            }
            while (choice.ToUpper() == "Y");
            Console.ReadLine();
        }
    }
}
