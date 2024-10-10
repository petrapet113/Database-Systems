using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class LekZaIzdavanje : Lek
    {
        public virtual int ProcenatParticipacije { get; set; }
        public virtual IList<Prepisan> PrepisanRecepti { get; set; }
        public LekZaIzdavanje()
        {
            PrepisanRecepti = new List<Prepisan>();

        }

    }
}
