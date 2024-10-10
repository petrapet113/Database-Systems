using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekat.Entiteti
{
    public class PrepisanId
    {
        public virtual LekZaIzdavanje PrepisanLekZaIzdavanje { get; set; }
        public virtual Recept PrepisanRecept { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(PrepisanId))
                return false;

            PrepisanId recievedObject = (PrepisanId)obj;

            if ((PrepisanLekZaIzdavanje.Id == recievedObject.PrepisanLekZaIzdavanje.Id) &&
                (PrepisanRecept.SerijskiBroj == recievedObject.PrepisanRecept.SerijskiBroj ))
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
