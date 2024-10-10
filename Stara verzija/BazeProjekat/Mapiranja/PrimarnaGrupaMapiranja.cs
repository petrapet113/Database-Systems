using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;

namespace BazeProjekat.Mapiranja
{
    class PrimarnaGrupaMapiranja :ClassMap<PrimarnaGrupa>
    {
        public PrimarnaGrupaMapiranja()
        {
            Table("PRIMARNA_GRUPA");

            Id(x => x.Naziv, "NAZIV").GeneratedBy.Assigned();
            HasMany(x => x.Lekovi).KeyColumn("NAZIVPRIMGRUPE").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Recepti)
                .Table("SADRŽI_TIP")
                .ParentKeyColumn("NAZIVPRIMGRUPE")
                .ChildKeyColumn("SERBR")
                .Cascade.All().Inverse();

        }
    }
}
