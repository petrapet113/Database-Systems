using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazeProjekat.Entiteti;
using FluentNHibernate.Mapping;


namespace BazeProjekat.Mapiranja
{
    class SePakujeMapiranja : ClassMap<SePakuje>
    {
        public SePakujeMapiranja()
        {
            Table("SE_PAKUJE");

            CompositeId(x => x.Id)
                .KeyReference(x => x.SePakujeVrstaPakovanja, "PAKOVANJEID")
                .KeyReference(x => x.LekSePakujeU, "LEKID");

            Map(x => x.Količina).Column("KOLIČINA");
            Map(x => x.Sastav).Column("SASTAV");

        }
    }

}
