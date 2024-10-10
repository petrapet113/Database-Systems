using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekat.Entiteti
{
    public class VrstaPakovanja
    {
        public virtual int Id { get; protected set; }
        public virtual string Tip { get; set; }
        public virtual IList<Recept> Recepti { get; set; }
        public virtual IList<SePakuje> SePakujeLekovi { get; set; }

        public VrstaPakovanja()
        {
            Recepti = new List<Recept>();
            SePakujeLekovi = new List<SePakuje>();

        }


    }
}
