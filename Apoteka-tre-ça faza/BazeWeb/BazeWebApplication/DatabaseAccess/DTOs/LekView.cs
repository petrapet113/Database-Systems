using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class LekView
    {
		public int Id { get; set; }
		public int DozaDeca { get; set; }
		public int DozaOdrasli { get; set; }
		public int DozaTrudnice { get; set; }
		public string KomercijalniNaziv { get; set; }
		public string HemijskiNaziv { get; set; }
		public int Cena { get; set; }
		public string proizvodjac;
		public int Kolicina { get; set; }
		public Proizvođač ProizvodiLek { get; set; }
		public PrimarnaGrupa JePrimarnaGrupa { get; set; }

		public virtual IList<LekKontraindikacijeView> KontraindikacijeLekovi { get; set; }
		public virtual IList<LekNeželjeniEfektiView> NeželjeniEfektiLekovi { get; set; }
		public virtual IList<SeNalaziView> SeNalaziProdajnaMesta { get; set; } //nemamo nigde SeNalaziView
		public virtual IList<BolestView> Bolesti { get; set; }

		public LekView()
		{
			KontraindikacijeLekovi = new List<LekKontraindikacijeView>();
			NeželjeniEfektiLekovi = new List<LekNeželjeniEfektiView>();
			SeNalaziProdajnaMesta = new List<SeNalaziView>(); //nemamo nigde SeNalaziView
			Bolesti = new List<BolestView>();

		}
		public LekView(int id, int dozadeca, int dozaodrasli, int dozatrudnice, string komercijalninaziv, string hemijskinaziv, int cena)
		{
			this.Id = id;
			this.DozaDeca = dozadeca;
			this.DozaOdrasli = dozaodrasli;
			this.DozaTrudnice = dozatrudnice;
			this.KomercijalniNaziv = komercijalninaziv;
			this.HemijskiNaziv = hemijskinaziv;
			this.Cena = cena;
		}
		public LekView(int id, int dozadeca, int dozaodrasli, int dozatrudnice, string komercijalninaziv, string hemijskinaziv, int cena, int kol, string proiz)
		{
			this.Id = id;
			this.DozaDeca = dozadeca;
			this.DozaOdrasli = dozaodrasli;
			this.DozaTrudnice = dozatrudnice;
			this.KomercijalniNaziv = komercijalninaziv;
			this.HemijskiNaziv = hemijskinaziv;
			this.Cena = cena;
			Kolicina = kol;
			proizvodjac = proiz;
		}
		public LekView(int id, int dozadeca, int dozaodrasli, int dozatrudnice, string komercijalninaziv, string hemijskinaziv, int cena,string proiz)
		{
			this.Id = id;
			this.DozaDeca = dozadeca;
			this.DozaOdrasli = dozaodrasli;
			this.DozaTrudnice = dozatrudnice;
			this.KomercijalniNaziv = komercijalninaziv;
			this.HemijskiNaziv = hemijskinaziv;
			this.Cena = cena;

			proizvodjac = proiz;
		}
		internal LekView(LekView l)
		{
			if (l != null)
			{
				Id = l.Id;
				DozaDeca = l.DozaDeca;
				DozaOdrasli = l.DozaOdrasli;
				DozaTrudnice = l.DozaTrudnice;
				KomercijalniNaziv = l.KomercijalniNaziv;
				HemijskiNaziv = l.HemijskiNaziv;
				Cena = l.Cena;
				Kolicina = l.Kolicina;
				ProizvodiLek = l.ProizvodiLek;
				JePrimarnaGrupa = l.JePrimarnaGrupa;

			}
		}
	}
}
