using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;

namespace BazeProjekat.Mapiranja
{
    class ProizvođačMapiranja : ClassMap<Proizvođač>
    {
        public ProizvođačMapiranja()
        {
            Table("PROIZVOĐAČ");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity();

            //mapiranje svojstava.
            Map(x => x.Naziv, "NAZIV");
            HasMany(x => x.Lekovi).KeyColumn("IDPROIZVOĐAČA").LazyLoad().Cascade.All().Inverse();
        }

    }
}
