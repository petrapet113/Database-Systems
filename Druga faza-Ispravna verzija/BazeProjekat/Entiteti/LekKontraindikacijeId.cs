using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BazeProjekat.Entiteti
{
    public class LekKontraindikacijeId
    {
        public virtual string KontraindikacijeLeka { get; set; }
        public virtual Lek LekImaKontraindikacije { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(LekKontraindikacijeId))
                return false;

            LekKontraindikacijeId recievedObject = (LekKontraindikacijeId)obj;

            if ((KontraindikacijeLeka == recievedObject.KontraindikacijeLeka) &&
                (LekImaKontraindikacije.Id == recievedObject.LekImaKontraindikacije.Id))
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
