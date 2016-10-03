using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broodjeszaak
{
    public class Martino : Broodjes
    {
        public Martino()
        {
            beschrijving = "Martino";
        }
        public override double Kost()
        {
            return 4.20;
        }

        public override string GeefBeschrijving()
        {
            return beschrijving;
        }
    }

    public class Smos : Broodjes
    {
        public Smos()
        {
            beschrijving = "Smos";
        }
        public override double Kost()
        {
            return 3.50;
        }

        public override string GeefBeschrijving()
        {
            return beschrijving;
        }
    }

    public class GebradenKip : Broodjes
    {
        public GebradenKip()
        {
            beschrijving = "GebradenKip";
        }
        public override double Kost()
        {
            return 3.70;
        }

        public override string GeefBeschrijving()
        {
            return beschrijving;
        }
    }
}
