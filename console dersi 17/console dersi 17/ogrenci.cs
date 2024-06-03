using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_17
{
    internal class ogrenci
    {
        private string ad;
        private string soyad;
        private int yas;

        public string adı
        {
            get { return ad; } 
            set { ad = value; }
        }
        public string soyadı
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int yası
        {
            get { return yas; }
            set
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }

    }
}
