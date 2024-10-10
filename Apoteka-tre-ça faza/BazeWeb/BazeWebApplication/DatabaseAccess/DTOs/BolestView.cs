using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class BolestView
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public virtual IList<LekView> Lekovi { get; set; }

        public BolestView()
        {
            Lekovi = new List<LekView>();
        }
        internal BolestView(Bolest b)
        {
            if (b != null)
            {
                Id = b.Id;
                Naziv = b.Naziv;

            }
        }

        public BolestView(string naziv)
        {
            Naziv = naziv;
        }

        public BolestView(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }
    }

    public class BolesDodaj
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

    }
}
