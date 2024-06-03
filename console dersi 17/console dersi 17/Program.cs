using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogr=new ogrenci();
            ogr.adı = "ismail";
            ogr.soyadı = "tosun";
            ogr.yası = 12;
            Console.WriteLine("adı:" + ogr.adı);
            Console.WriteLine("soyadı:" + ogr.soyadı);
            Console.WriteLine("yası:" + ogr.yası);
            Console.ReadLine();
        }
    }
}
