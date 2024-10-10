using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;

namespace BazeProjekat.Mapiranja
{
    class LekZaIzdavanjeMapiranja : SubclassMap<LekZaIzdavanje>
    {
        public LekZaIzdavanjeMapiranja()
        {
            Table("LEK_ZA_IZDAVANJE");
            KeyColumn("ID");
            Map(x => x.ProcenatParticipacije).Column("PROCENAT_PARTICIPACIJE");
            HasMany(x => x.PrepisanRecepti).KeyColumn("LEKID").LazyLoad().Cascade.All().Inverse();
        }
    }
}
