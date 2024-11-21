using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TinhTong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so luong phan tu cua mang");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr=new int[n];

            Console.WriteLine("Nhap gia tri cho mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Phan tu thu {i+1} : ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            int Tong = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                Tong+=arr[i];
            }
            Console.WriteLine("Tong cac phan tu trong mang la:"+ Tong);
        }
    }
}
