using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;


namespace DatabaseAccess.Mapiranja
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
