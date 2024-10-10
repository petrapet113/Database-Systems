using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class FarmaceutMapiranja : SubclassMap<Farmaceut>
    {
        public FarmaceutMapiranja()
        {
            Table("FARMACEUT");
            KeyColumn("JMBG");
            Map(x => x.DatumDiplomiranja).Column("DATUM_DIPLOMIRANJA");
            Map(x => x.DatumObnoveLicence).Column("DATUM_OBNOVE_LICENCE");
            HasMany(x => x.RealizujeRecepte).KeyColumn("JMBGZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
        }
    }
}
