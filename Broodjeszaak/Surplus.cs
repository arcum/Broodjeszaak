using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broodjeszaak
{
    public abstract class Surplus : Broodjes
    {
        public abstract override double Kost();
        public abstract override string GeefBeschrijving();
    }
}
