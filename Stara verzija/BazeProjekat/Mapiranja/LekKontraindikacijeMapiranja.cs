using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;


namespace BazeProjekat.Mapiranja
{
 
        class LekKontraindikacijeMapiranja : ClassMap<LekKontraindikacije>
        {
            public LekKontraindikacijeMapiranja()
            {
                Table("LEK_KONTRAINDIKACIJE");

                CompositeId(x => x.Id)
                    .KeyProperty(x => x.KontraindikacijeLeka, "KONTRAINDIKACIJE")
                    .KeyReference(x => x.LekImaKontraindikacije, "LEKID");


            }
        }

}

