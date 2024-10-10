using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazeProjekat.Entiteti;

namespace BazeProjekat
{
    #region ProdajnoMesto
    public class ProdajnoMestoPregled
	{
		public string Naziv;
		public int Id;
		public string Ulica;
		public string Grad;
		public int Broj;
		public virtual IList<Zaposleni> Zaposleni { get; set; }
		public ProdajnoMestoPregled()
		{
			Zaposleni = new List<Zaposleni>();

		}

		public ProdajnoMestoPregled(int id, string naziv, string ulica, string grad, int broj)
		{
			this.Id = id;
			this.Naziv = naziv;
			this.Ulica = ulica;
			this.Grad = grad;
			this.Broj = broj;
		}

	}
	public class ProdajnoMestoBasic
	{
		public string Naziv;
		public int Id;
		public string Ulica;
		public string Grad;
		public int Broj;
		public virtual IList<Zaposleni> Zaposleni { get; set; }
		public virtual IList<Recept> Recepti { get; set; }

		public ProdajnoMestoBasic()
		{
			Zaposleni = new List<Zaposleni>();
			Recepti = new List<Recept>();
		}

		public ProdajnoMestoBasic(int id, string naziv, string ulica, string grad, int broj)
		{
			this.Id = id;
			this.Naziv = naziv;
			this.Ulica = ulica;
			this.Grad = grad;
			this.Broj = broj;
		}
	}
	#endregion
	#region Zaposleni

	public class ZaposleniPregled
	{
		public long JMBG;
		public string Ime;
		public string Prezime;
		public string Ulica;
		public string Grad;
		public int Broj;
		public DateTime DatumRođenja;
		public string RadnoMesto;
		public virtual IList<ZaposleniBrTel> BrojeviTelefonaZaposlenog { get; set; }
		public virtual ProdajnoMestoBasic RadiUProdMesto { get; set; }

		public ZaposleniPregled()
		{

		}
		public ZaposleniPregled(long jmbg, string ime, string prezime, string ulica, string grad, int broj, DateTime datumrođenja)
		{
			this.JMBG = jmbg;
			this.Ime = ime;
			this.Prezime = prezime;
			this.Ulica = ulica;
			this.Grad = grad;
			this.Broj = broj;
			this.DatumRođenja = datumrođenja;
		}
		public ZaposleniPregled(long jmbg, string ime, string prezime, string ulica, string grad, int broj, DateTime datumrođenja,string mesto)
		{
			this.JMBG = jmbg;
			this.Ime = ime;
			this.Prezime = prezime;
			this.Ulica = ulica;
			this.Grad = grad;
			this.Broj = broj;
			this.DatumRođenja = datumrođenja;
			RadnoMesto = mesto;
		}


	}
	public class ZaposleniBasic
	{
		public long JMBG;
		public string Ime;
		public string Prezime;
		public string Ulica;
		public string Grad;
		public int Broj;
		public DateTime DatumRođenja;
		public virtual ProdajnoMestoBasic RadiUProdMesto { get; set; }


		public ZaposleniBasic()
		{
			
		}
		public ZaposleniBasic(long jmbg, string ime, string prezime, string ulica, string grad, int broj, DateTime datumrođenja)
		{
			this.JMBG = jmbg;
			this.Ime = ime;
			this.Prezime = prezime;
			this.Ulica = ulica;
			this.Grad = grad;
			this.Broj = broj;
			this.DatumRođenja = datumrođenja;
			
			
		}


	}

	//public class ZaposleniBrTelBasic
	//   {
	//	public int
	//   }

	#endregion

	#region Lek
	public class LekBasic
	{

		public int Id;
		public int DozaDeca;
		public int DozaOdrasli;
		public int DozaTrudnice;
		public string KomercijalniNaziv;
		public string HemijskiNaziv;
		public int Cena;
		public int Kolicina;
		public Proizvođač ProizvodiLek { get; set; }
		public  PrimarnaGrupa JePrimarnaGrupa { get; set; }
		public virtual IList<LekKontraindikacije> KontraindikacijeLekovi { get; set; }
		public virtual IList<LekNeželjeniEfekti> NeželjeniEfektiLekovi { get; set; }
		public virtual IList<SeNalazi> SeNalaziProdajnaMesta { get; set; }
		public virtual IList<Bolest> Bolesti { get; set; }


		public LekBasic()
		{ }

		public LekBasic(int id, int dozadeca, int dozaodrasli, int dozatrudnice, string komercijalninaziv, string hemijskinaziv, int cena)
		{
			this.Id = id;
			this.DozaDeca = dozadeca;
			this.DozaOdrasli = dozaodrasli;
			this.DozaTrudnice = dozatrudnice;
			this.KomercijalniNaziv = komercijalninaziv;
			this.HemijskiNaziv = hemijskinaziv;
			this.Cena = cena;
		}
		public LekBasic(int id, int dozadeca, int dozaodrasli, int dozatrudnice, string komercijalninaziv, string hemijskinaziv, int cena,int kol)
		{
			this.Id = id;
			this.DozaDeca = dozadeca;
			this.DozaOdrasli = dozaodrasli;
			this.DozaTrudnice = dozatrudnice;
			this.KomercijalniNaziv = komercijalninaziv;
			this.HemijskiNaziv = hemijskinaziv;
			this.Cena = cena;
			Kolicina = kol;
		}
	}
	public class LekPregled
	{

		public int Id;
		public int DozaDeca;
		public int DozaOdrasli;
		public int DozaTrudnice;
		public string KomercijalniNaziv;
		public string HemijskiNaziv;
		public int Cena;
		public string proizvodjac;
		public Proizvođač ProizvodiLek { get; set; }
		public PrimarnaGrupa JePrimarnaGrupa { get; set; }
		public int Kolicina;
		public virtual IList<SeNalazi> SeNalaziProdajnaMesta { get; set; }

		public LekPregled()
		{ }

		public LekPregled(int id, int dozadeca, int dozaodrasli, int dozatrudnice, string komercijalninaziv, string hemijskinaziv, int cena)
		{
			this.Id = id;
			this.DozaDeca = dozadeca;
			this.DozaOdrasli = dozaodrasli;
			this.DozaTrudnice = dozatrudnice;
			this.KomercijalniNaziv = komercijalninaziv;
			this.HemijskiNaziv = hemijskinaziv;
			this.Cena = cena;
		}
		public LekPregled(int id, int dozadeca, int dozaodrasli, int dozatrudnice, string komercijalninaziv, string hemijskinaziv, int cena,int kol,string proiz)
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
		public LekPregled(int id, int dozadeca, int dozaodrasli, int dozatrudnice, string komercijalninaziv, string hemijskinaziv, int cena, string proiz)
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
	}

	#endregion

	#region LekNezeljeniEfekti
	public class NezeljeniEfektiBasic
    {
		public  LekNeželjeniEfektiId Id { get; set; }

		public NezeljeniEfektiBasic()
		{
			Id = new LekNeželjeniEfektiId();
		}


	}
	#endregion
	#region LekKontraindikacije
	public class KontraindikacijeBasic
	{
		public  LekKontraindikacijeId Id { get; set; }

		public KontraindikacijeBasic()
		{
			Id = new LekKontraindikacijeId();
		}

	}
	#endregion
	#region PrimarnaGrupa
	public class PrimarnaGrupaBasic
	{
		public string Naziv;
		public IList<Lek> Lekovi;
		public IList<Recept> Recepti;

		public PrimarnaGrupaBasic()
		{
			Lekovi = new List<Lek>();
			Recepti = new List<Recept>();
		}

		public PrimarnaGrupaBasic(string naziv)
		{
			this.Naziv = naziv;
		}
	}
	#endregion
	#region Bolest
	public class BolestBasic
	{
		public int Id;
		public string Naziv;
		public IList<Lek> Lekovi;

		public BolestBasic()
		{
			Lekovi = new List<Lek>();
		}

		public BolestBasic(int id, string naziv)
		{
			this.Id = id;
			this.Naziv = naziv;
		}
	}
	public class BolestPregled
	{
		public int Id;
		public string Naziv;
		public IList<Lek> Lekovi;

		public BolestPregled()
		{
			Lekovi = new List<Lek>();
		}

		public BolestPregled( string naziv)
		{
			
			this.Naziv = naziv;
		}
	}
	#endregion
	#region Recept
	public class ReceptBasic
	{

		public int SerijskiBroj;
		public ProdajnoMesto RealizovanNa;
		public Lekar IzdajeRecept;
		public Farmaceut FarmaceutRealizuje;
		public string ImeLekara;
		public string ImeFarmaceuta;
		public string PrezimeLekara;
		public string PrezimeFarmaceuta;
		public string PrepisanLek;
		public List<string> primarnegrupe;
		public List<string> vrstepakovanja;

		public IList<VrstaPakovanja> VrstePakovanja;
		public IList<PrimarnaGrupa> PrimarnaGrupa;
		public IList<Prepisan> PrepisanLekoviZaIzdavanje;


		public ReceptBasic()
		{
			VrstePakovanja = new List<VrstaPakovanja>();
			PrimarnaGrupa = new List<PrimarnaGrupa>();
			PrepisanLekoviZaIzdavanje = new List<Prepisan>();
			primarnegrupe = new List<string>();
			vrstepakovanja = new List<string>();
			
		}
		public ReceptBasic(int serijskibroj,string imeL,string imeF,string pL,string pF)
		{

			this.SerijskiBroj = serijskibroj;
			ImeLekara = imeL;
			ImeFarmaceuta = imeF;
			PrezimeFarmaceuta = pF;
			PrezimeLekara = pL;
			
			
		}
	}
	#endregion
}
