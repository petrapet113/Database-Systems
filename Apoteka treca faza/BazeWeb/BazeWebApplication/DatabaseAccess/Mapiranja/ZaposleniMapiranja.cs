using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
		public ZaposleniMapiranja()
		{
			Table("ZAPOSLENI");

			Id(x => x.JMBG, "JMBG").GeneratedBy.Assigned();

			Map(x => x.Ime, "IME");
			Map(x => x.Prezime, "PREZIME");
			Map(x => x.Ulica, "ULICA");
			Map(x => x.Broj, "BROJ");
			Map(x => x.Grad, "GRAD");
			Map(x => x.DatumRođenja, "DATUM_ROĐENJA");

			References(x => x.RadiUProdMesto).Column("PRODMESTOID").LazyLoad();
			HasMany(x => x.BrojeviTelefonaZaposlenog).KeyColumn("JMBGZAPOSLENOG").LazyLoad().Cascade.All().Inverse();




		}

	}
}
