using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ZP_M326_Tino_Stoeckli
{
    internal class FliegenGarNicht : IFlugfaehig
    {
        public void fliegen()
        {
            Console.WriteLine("Ich kann nicht fligen");
        }
    }
}
