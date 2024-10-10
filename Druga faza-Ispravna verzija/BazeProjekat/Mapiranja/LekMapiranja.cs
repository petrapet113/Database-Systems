using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;
using System.Threading.Tasks;

namespace BazeProjekat.Mapiranja
{
    public class LekMapiranja : ClassMap<Lek>
    {
        public LekMapiranja()
        {
			Table("LEK");

			Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

			Map(x => x.KomercijalniNaziv, "KOMERCIJALNI_NAZIV");
			Map(x => x.HemijskiNaziv, "HEMIJSKI_NAZIV");
			Map(x => x.DozaDeca, "DOZA_DECA");
			Map(x => x.DozaOdrasli, "DOZA_ODRASLI");
			Map(x => x.DozaTrudnice, "DOZA_TRUDNICE");
			Map(x => x.Cena, "CENA");

			References(x => x.JePrimarnaGrupa).Column("NAZIVPRIMGRUPE").LazyLoad();
			References(x => x.ProizvodiLek).Column("IDPROIZVOĐAČA").LazyLoad();

			HasManyToMany(x => x.Bolesti)
				.Table("LEČI")
				.ParentKeyColumn("LEKID")
				.ChildKeyColumn("BOLESTID")
				.Cascade.All();
			HasMany(x => x.SeNalaziProdajnaMesta).KeyColumn("LEKID").LazyLoad().Cascade.All().Inverse();
			HasMany(x => x.SePakujeVrstePakovanja).KeyColumn("LEKID").LazyLoad().Cascade.All().Inverse();
			HasMany(x => x.KontraindikacijeLekovi).KeyColumn("LEKID").LazyLoad().Cascade.All().Inverse();
			HasMany(x => x.NeželjeniEfektiLekovi).KeyColumn("LEKID").LazyLoad().Cascade.All().Inverse();



		}
	}
}
