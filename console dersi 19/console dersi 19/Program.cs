using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_19
{
    internal class Program
    {
        static void arttir(ref int b)
        {
            b++;
        }

        static void Main(string[] args)
        {
            int a = 0;
            arttir(ref a);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
