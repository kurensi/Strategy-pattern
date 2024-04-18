using System;

namespace _2ZP_M326_Tino_Stoeckli
{
    class Program
    {
        static void Main(string[] args)
        {

            Ente Tedy = new StockEnte();
            Tedy.anzeigen();
            Tedy.toQuacken();
            Tedy.toFliegen();
            Tedy.schwimmen();
            Tedy.setFlugVerhalten(new FliegenGarNicht());
            Tedy.toFliegen();

        }
    }
}
