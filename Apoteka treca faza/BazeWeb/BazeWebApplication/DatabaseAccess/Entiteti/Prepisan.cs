using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Prepisan
    {
        public virtual PrepisanId Id { get; set; }
        public virtual string Količina { get; set; }


        public Prepisan()
        {
            Id = new PrepisanId();
        }

    }
}
