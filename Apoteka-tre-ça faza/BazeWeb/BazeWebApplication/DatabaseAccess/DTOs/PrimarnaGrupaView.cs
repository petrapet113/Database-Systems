using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class PrimarnaGrupaView
    {
        public string Naziv { get; set; }
        public virtual IList<LekView> Lekovi { get; set; }
        public virtual IList<ReceptView> Recepti { get; set; }

        public PrimarnaGrupaView()
        {
            Lekovi = new List<LekView>();
            Recepti = new List<ReceptView>();
        }

        internal PrimarnaGrupaView(PrimarnaGrupa pg)
        {
            if (pg != null)
            {

                Naziv = pg.Naziv;

            }
        }
    }
}
