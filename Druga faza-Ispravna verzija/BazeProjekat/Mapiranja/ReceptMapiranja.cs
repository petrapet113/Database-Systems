using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;

namespace BazeProjekat.Mapiranja
{
    class ReceptMapiranja : ClassMap<Recept>
    {
        public ReceptMapiranja()
        {
            Table("RECEPT");

            //mapiranje primarnog kljuca

            Id(x => x.SerijskiBroj, "SERIJSKI_BROJ").GeneratedBy.TriggerIdentity();
            References(x => x.RealizovanNa).Column("PRODMESTOID").LazyLoad();
            References(x => x.IzdajeRecept).Column("ŠIFRALEKARA").LazyLoad();
            References(x => x.FarmaceutRealizuje).Column("JMBGZAPOSLENOG").LazyLoad();
            HasManyToMany(x => x.VrstePakovanja)
                 .Table("SADRŽI_VRSTU")
                 .ParentKeyColumn("SERBR")
                 .ChildKeyColumn("VRSTAID")
                 .Cascade.All();
            HasManyToMany(x => x.PrimarneGrupe)
                 .Table("SADRŽI_TIP")
                 .ParentKeyColumn("SERBR")
                 .ChildKeyColumn("NAZIVPRIMGRUPE")
                 .Cascade.All();
            HasMany(x => x.PrepisanLekoviZaIzdavanje).KeyColumn("SERBR").LazyLoad().Cascade.All().Inverse();

        }

    }
}
