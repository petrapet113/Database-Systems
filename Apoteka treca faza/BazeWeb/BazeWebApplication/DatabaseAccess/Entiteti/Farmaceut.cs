using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Farmaceut : Zaposleni
    {
        public virtual DateTime DatumObnoveLicence { get; set; }
        public virtual DateTime DatumDiplomiranja { get; set; }
        public virtual IList<Recept> RealizujeRecepte { get; set; }
        public Farmaceut()
        {
            RealizujeRecepte = new List<Recept>();
        }

    }
}
