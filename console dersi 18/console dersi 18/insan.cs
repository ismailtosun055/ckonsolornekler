using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_18
{
    internal class insan
    {
        public virtual void selamver()
        {
            Console.BackgroundColor= ConsoleColor.Red;
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Title = "28 aralık çarşamba";
            Console.WriteLine("MERHABA DÜNYALLILAR");
            Console.ReadLine();
        }
    }
}
