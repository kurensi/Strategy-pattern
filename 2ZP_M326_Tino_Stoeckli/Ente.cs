using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ZP_M326_Tino_Stoeckli
{
    public abstract class Ente
    {
        public IFlugfaehig flugfaehig;
        public IQuackenfaehig quackfaehig;
        public virtual void toFliegen()
        {
            flugfaehig.fliegen();
        }
        public virtual void toQuacken()
        {
            quackfaehig.quacken();
        }
        public void setFlugVerhalten(IFlugfaehig fv)
        {
            flugfaehig = fv;
        }
        public void setQuckVerhalten(IQuackenfaehig qv)
        {
            quackfaehig = qv;
        }
        public virtual void schwimmen()
        {
            Console.WriteLine("Ich kann schwimmen");
        }
        public abstract void anzeigen();
    }
}
