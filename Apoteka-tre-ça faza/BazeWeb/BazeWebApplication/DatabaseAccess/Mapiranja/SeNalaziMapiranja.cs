using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    public class SeNalaziMapiranja : ClassMap<SeNalazi>
    {
        public SeNalaziMapiranja()
        {
            Table("SE_NALAZI");

            CompositeId(x => x.Id)
                .KeyReference(x => x.SeNalaziProdajnoMesto, "PRODMESTOID")
                .KeyReference(x => x.LekSeNalaziU, "LEKID");

            Map(x => x.Količina).Column("KOLIČINA");

        }
    }

}
