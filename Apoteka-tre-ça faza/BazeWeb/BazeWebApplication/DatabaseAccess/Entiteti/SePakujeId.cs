using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class SePakujeId
    {
        public virtual VrstaPakovanja SePakujeVrstaPakovanja { get; set; }
        public virtual Lek LekSePakujeU { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(SePakujeId))
                return false;

            SePakujeId recievedObject = (SePakujeId)obj;

            if ((SePakujeVrstaPakovanja.Id == recievedObject.SePakujeVrstaPakovanja.Id) &&
                (LekSePakujeU.Id == recievedObject.LekSePakujeU.Id ))
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
