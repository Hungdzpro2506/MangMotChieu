using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GiaTriLonNhat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so phan tu cua mang: ");
            int N = int.Parse(Console.ReadLine());
            int[] arr;
            do
            {
                
                if (N > 20)
                {
                    Console.WriteLine("nhap N <= 20!");

                }
            }
            while (N > 20);
            arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Phan tu thu {i+1}: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("danh sach da nhap la: ");
            for (int j = 0;j < arr.Length; j++)
            {
                
                Console.WriteLine(arr[j]);
            }
            int Max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];

                }
            }
            Console.WriteLine("Gia tri max la: " + Max);
        }
    }
}
