using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    public class ProdajnoMestoMapiranja : ClassMap<ProdajnoMesto>
    {
        public ProdajnoMestoMapiranja()
        {
            Table("PRODAJNO_MESTO");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");

            HasMany(x => x.Zaposleni).KeyColumn("PRODMESTOID").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Recepti).KeyColumn("PRODMESTOID").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.SeNalaziLekovi).KeyColumn("PRODMESTOID").LazyLoad().Cascade.All().Inverse();



        }
    }
}
