using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekat.Entiteti
{
    public class SePakuje
    {
        public virtual SePakujeId Id { get; set; }
        public virtual int Količina { get; set; }
        public virtual string Sastav { get; set; }


        public SePakuje()
        {
            Id = new SePakujeId();
        }

    }

}
