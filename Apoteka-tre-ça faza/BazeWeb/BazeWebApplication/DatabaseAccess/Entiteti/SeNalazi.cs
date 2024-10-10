using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class SeNalazi
    {
        public virtual SeNalaziId Id { get; set; }
        public virtual int Količina { get; set; }


        public SeNalazi()
        {
            Id = new SeNalaziId();
        }

    }
}
