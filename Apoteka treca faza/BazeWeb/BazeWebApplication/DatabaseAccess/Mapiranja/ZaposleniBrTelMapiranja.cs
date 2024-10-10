using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class ZaposleniBrTelMapiranja : ClassMap<ZaposleniBrTel>
    {
        public ZaposleniBrTelMapiranja() 
        {
            Table("ZAPOSLENI_BRTEL");

            CompositeId(x => x.Id)
                .KeyProperty(x => x.BrTelefonaZaposlenog, "BROJTELEFONA")
                .KeyReference(x => x.ZaposleniImaBrTelefona, "JMBGZAPOSLENOG");




        }
    }

}
