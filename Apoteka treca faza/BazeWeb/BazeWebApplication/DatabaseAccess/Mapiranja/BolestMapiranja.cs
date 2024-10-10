using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class BolestMapiranja : ClassMap<Bolest>
    {
        public BolestMapiranja()
        {
            Table("BOLEST");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity();

            //mapiranje svojstava.
            Map(x => x.Naziv, "NAZIV");
            HasManyToMany(x => x.Lekovi)
                .Table("LEČI")
                .ParentKeyColumn("BOLESTID")
                .ChildKeyColumn("LEKID")
                .Cascade.All()
                .Inverse();


        }

    }
}
