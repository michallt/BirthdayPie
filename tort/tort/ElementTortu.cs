using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tort
{
    public class ElementTortu
    {
        public int swieczka;
        public bool czy_zapalony;

        public ElementTortu(int a, bool b)
        {
            swieczka = a;
            czy_zapalony = b;
        }

        public void wypisz()
        {
            Console.Write(swieczka + " " + czy_zapalony + " ");
        }

      

    }
}
