using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class ProdajnoMesto
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Grad { get; set; }
        public virtual IList<Zaposleni> Zaposleni { get; set; } 
        public virtual IList<Recept> Recepti { get; set; }
        public virtual IList<SeNalazi> SeNalaziLekovi { get; set; }


        public ProdajnoMesto()
        {
            Zaposleni = new List<Zaposleni>();
            Recepti = new List<Recept>();
            SeNalaziLekovi = new List<SeNalazi>();


        }
    }
}
