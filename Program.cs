using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Restaurant {
    class Program {
        static void Main(string[] args) {
            Carta c = new Carta();
            c.init();

            Console.ReadKey();
        }
    }
}