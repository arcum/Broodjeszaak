using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broodjeszaak
{
    public abstract class Broodjes
    {
        protected string beschrijving = "Broodje";

        public abstract string GeefBeschrijving();
        public abstract double Kost();
    }
}
