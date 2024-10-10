using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BazeProjekat.Entiteti
{
    public class LekKontraindikacije
    {

        public virtual LekKontraindikacijeId Id { get; set; }

        public LekKontraindikacije()
        {
            Id = new LekKontraindikacijeId();
        }
    }
}
