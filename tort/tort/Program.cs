using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tort
{
    class Program
    {
        static void Main(string[] args)
        {
            Tort t1 = new Tort();

            t1.generuj_tort(t1.element);
            t1.zdmuchuj_swieczki(t1.element);
            


            Console.ReadKey();
        }
    }
}
