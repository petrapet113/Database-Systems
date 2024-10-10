using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;

namespace BazeProjekat.Mapiranja
{
    class PrepisanMapiranja : ClassMap<Prepisan>
    {
        public PrepisanMapiranja()
        {
            Table("PREPISAN");

            CompositeId(x => x.Id)
                .KeyReference(x => x.PrepisanLekZaIzdavanje, "LEKID")
                .KeyReference(x => x.PrepisanRecept, "SERIJSKIBROJ");

            Map(x => x.Količina).Column("KOLIČINA");

        }
    }

}
