using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class SeNalaziId
    {
        public virtual ProdajnoMesto SeNalaziProdajnoMesto { get; set; }
        public virtual Lek LekSeNalaziU { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(SeNalaziId))
                return false;

            SeNalaziId recievedObject = (SeNalaziId)obj;

            if ((SeNalaziProdajnoMesto.Id == recievedObject.SeNalaziProdajnoMesto.Id) &&
                (LekSeNalaziU.Id == recievedObject.LekSeNalaziU.Id ))
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

