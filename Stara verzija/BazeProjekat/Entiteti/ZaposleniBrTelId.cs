using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekat.Entiteti
{
    public class ZaposleniBrTelId
    {
        public virtual Zaposleni ZaposleniImaBrTelefona { get; set; }
        public virtual int BrTelefonaZaposlenog { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(ZaposleniBrTelId))
                return false;

            ZaposleniBrTelId recievedObject = (ZaposleniBrTelId)obj;

            if ((ZaposleniImaBrTelefona.JMBG == recievedObject.ZaposleniImaBrTelefona.JMBG) &&
                (BrTelefonaZaposlenog == recievedObject.BrTelefonaZaposlenog))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

}

