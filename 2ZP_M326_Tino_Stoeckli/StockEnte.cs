using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ZP_M326_Tino_Stoeckli
{
    class StockEnte : Ente
    {
        public StockEnte()
        {
            flugfaehig = new FliegenMitFluegel();
            quackfaehig = new Quacken();
        }

        public override void anzeigen()
        {
            Console.WriteLine("Ich bin eine Stockente");
        }
    }
}
