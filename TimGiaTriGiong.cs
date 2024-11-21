using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("nhap ten ban muon tim: ");
            string SearchName = Console.ReadLine();
            bool Tontai = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == SearchName) {
                    Console.WriteLine("Vi tri cua hoc sinh " + SearchName + $" trong danh sach la: {i+1} "  );
                    Tontai = true; break; }

            }
            if( !Tontai)
            {
                Console.WriteLine("khong ton tai!");
            }

        }
    }
}
