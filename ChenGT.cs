using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ChenGT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luon phan tu trong mang: ");
            int N = int.Parse(Console.ReadLine());
            int[] Arr = new int[N]; 
            Console.WriteLine("nhap cac phan tu trong mang: ");
            for (int i = 0; i < N; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("mang ban dau la: ");
            for(int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] +"  ");
            }
           Console.WriteLine("\nNhap so can chen: ");
            int X=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri can chen: ");
            int index = int.Parse(Console.ReadLine());
            if(index<0|| index >= Arr.Length)
            {
                Console.WriteLine("Vi tri khong hop le!");
                return;
            }
            for (int i=N-1; i > index; i--)
            {
                Arr[i] = Arr[i-1];

            }
            Arr[index] = X;
            for (int i = 0;i < Arr.Length;i++)
            {
                Console.Write(Arr[i]+"  ");
            }


        }
    }
}
