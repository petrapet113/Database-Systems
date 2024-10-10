using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class LekNeželjeniEfektiMapiranja : ClassMap<LekNeželjeniEfekti>
    {
        public LekNeželjeniEfektiMapiranja()
        {
            Table("LEK_NEŽELJENI_EFEKTI");

            CompositeId(x => x.Id)
                .KeyProperty(x => x.NeželjeniEfektiLeka, "NEŽELJENI_EFEKTI")
                .KeyReference(x => x.LekImaNeželjeneEfekte, "LEKID");


        }
    }

}
