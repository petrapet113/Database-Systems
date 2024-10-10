using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;

namespace BazeProjekat.Mapiranja
{
    class LekarMapiranja : ClassMap<Lekar>
    {
		public LekarMapiranja()
		{
			Table("LEKAR");

			Id(x => x.Šifra, "ŠIFRA").GeneratedBy.Assigned();

			Map(x => x.Ime, "IME");
			Map(x => x.Prezime, "PREZIME");
			Map(x => x.BrojTelefona, "BROJ_TELEFONA");
			HasMany(x => x.Recepti).KeyColumn("ŠIFRALEKARA").LazyLoad().Cascade.All().Inverse();
			


		}

	}
}
