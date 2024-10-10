using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Lekar
    {
        public virtual int Šifra { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int BrojTelefona { get; set; }

        public virtual IList<Recept> Recepti { get; set; }
        public Lekar()
        {
            Recepti = new List<Recept>();
        }

    }
}
