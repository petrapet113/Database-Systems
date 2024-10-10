using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class LekNeželjeniEfektiId
    {
        public virtual string NeželjeniEfektiLeka { get; set; }
        public virtual Lek LekImaNeželjeneEfekte { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(LekNeželjeniEfektiId))
                return false;

            LekNeželjeniEfektiId recievedObject = (LekNeželjeniEfektiId)obj;

            if ((NeželjeniEfektiLeka == recievedObject.NeželjeniEfektiLeka) &&
                (LekImaNeželjeneEfekte.Id == recievedObject.LekImaNeželjeneEfekte.Id))
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
