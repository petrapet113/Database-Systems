using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class PrimarnaGrupa
    {
        public virtual string Naziv{get; set;}
        public virtual IList<Lek> Lekovi { get; set; }
        public virtual IList<Recept> Recepti { get; set; }
        public PrimarnaGrupa()
        {
            Lekovi = new List<Lek>();
            Recepti = new List<Recept>();
        }
    }
}
