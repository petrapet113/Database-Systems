using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Proizvođač
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual IList<Lek> Lekovi { get; set; }


        public Proizvođač()
        {
            Lekovi = new List<Lek>();
        }

    }
}
