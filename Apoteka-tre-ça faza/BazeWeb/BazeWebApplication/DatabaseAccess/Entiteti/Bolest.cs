using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Bolest
    {
        public virtual int Id { get;  set; }
        public virtual string Naziv { get; set; }
        public virtual IList<Lek> Lekovi { get; set; }
        public Bolest()
        {
            Lekovi = new List<Lek>();
        }


    }
}
