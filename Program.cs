using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "甲乙丙丁戊己庚辛壬癸";
            string b = "子丑寅卯辰巳午未申酉戌亥";
            int x = 0;
            int y = 0;
            for (int i=0; i<60; i++)
            {
                Console.WriteLine(a[x].ToString() + b[y].ToString());
                if (++x >= a.Length) x = 0;
                if (++y >= b.Length) y = 0;
            }
            Console.ReadLine();
        }
    }
}
