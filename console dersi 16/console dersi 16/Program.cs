using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba arbsnf= new araba();
            arbsnf.renk = "siyah";
            arbsnf.model = "2023";
            arbsnf.fiyat = 1500000;

            Console.WriteLine("arabanın rengi:" + arbsnf.renk);
            Console.WriteLine("arabanın modeli:"+arbsnf.model);
            Console.WriteLine("arabanın fiyatı:" +arbsnf.fiyat);
            Console.ReadLine();
        }
    }
}
