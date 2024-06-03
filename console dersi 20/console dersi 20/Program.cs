using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_20
{
    internal class Program
    {
        static void arttir(out int s)
        {
            s = 15;
            s++;
        }
        static void Main(string[] args)
        {
            int a;
            arttir(out a);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
