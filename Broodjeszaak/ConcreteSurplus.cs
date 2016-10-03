using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broodjeszaak
{
    public class Ajuin : Surplus
    {
        Broodjes rx;

        public Ajuin(Broodjes rx)
        {
            this.rx = rx;
        }

        public override string GeefBeschrijving()
        {
            return rx.GeefBeschrijving() + ", met ajuin";
        }

        public override double Kost()
        {
            return rx.Kost() + 0.20;
        }
    }

    public class Mayo : Surplus
    {
        Broodjes rx;

        public Mayo(Broodjes rx)
        {
            this.rx = rx;
        }

        public override string GeefBeschrijving()
        {
            return rx.GeefBeschrijving() + ", met mayo";
        }

        public override double Kost()
        {
            return rx.Kost() + 0.10;
        }
    }

    public class Ketchup : Surplus
    {
        Broodjes rx;

        public Ketchup(Broodjes rx)
        {
            this.rx = rx;
        }

        public override string GeefBeschrijving()
        {
            return rx.GeefBeschrijving() + ", met ketchup";
        }

        public override double Kost()
        {
            return rx.Kost() + 0.15;
        }
    }
}
