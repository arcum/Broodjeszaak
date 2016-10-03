using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broodjeszaak
{
    public class Klein : Grootte
    {
        Broodjes rx;

        public Klein(Broodjes rx)
        {
            this.rx = rx;
        }

        public override string GeefBeschrijving()
        {
            return rx.GeefBeschrijving() + ", klein broodje";
        }

        public override double Kost()
        {
            return rx.Kost() + 1.20;
        }
    }

    public class Middel : Grootte
    {
        Broodjes rx;

        public Middel(Broodjes rx)
        {
            this.rx = rx;
        }

        public override string GeefBeschrijving()
        {
            return rx.GeefBeschrijving() + ", middelgroot broodje";
        }

        public override double Kost()
        {
            return rx.Kost() + 1.60;
        }
    }

    public class Groot : Grootte
    {
        Broodjes rx;

        public Groot(Broodjes rx)
        {
            this.rx = rx;
        }

        public override string GeefBeschrijving()
        {
            return rx.GeefBeschrijving() + ", groot broodje";
        }

        public override double Kost()
        {
            return rx.Kost() + 1.20;
        }
    }
}
