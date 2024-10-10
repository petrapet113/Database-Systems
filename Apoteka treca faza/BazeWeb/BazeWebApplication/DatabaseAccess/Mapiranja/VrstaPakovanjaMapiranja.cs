using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class VrstaPakovanjaMapiranja : ClassMap<VrstaPakovanja>
    {
        public VrstaPakovanjaMapiranja()
        {
            Table("VRSTA_PAKOVANJA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.Tip, "TIP");

            HasManyToMany(x => x.Recepti)
                .Table("SADRŽI_VRSTU")
                .ParentKeyColumn("VRSTAID")
                .ChildKeyColumn("SERBR")
                .Cascade.All().Inverse();
            HasMany(x => x.SePakujeLekovi).KeyColumn("PAKOVANJEID").LazyLoad().Cascade.All().Inverse();



        }
    }
}
