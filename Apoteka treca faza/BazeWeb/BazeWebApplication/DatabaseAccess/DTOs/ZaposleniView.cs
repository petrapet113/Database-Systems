using System;
using System.Collections.Generic;
using System.Text;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ZaposleniView
    {
		public long JMBG { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Ulica { get; set; }
		public string Grad { get; set; }
		public int Broj { get; set; }
		public DateTime DatumRođenja { get; set; }
		public string RadnoMesto { get; set; }
		public virtual IList<ZaposleniBrTelView> BrojeviTelefonaZaposlenog { get; set; }
		public virtual ProdajnoMesto? RadiUProdMesto { get; set; }

		public ZaposleniView()
		{

		}
		public ZaposleniView(long jmbg, string ime, string prezime, string ulica, string grad, int broj, DateTime datumrođenja)
		{
			this.JMBG = jmbg;
			this.Ime = ime;
			this.Prezime = prezime;
			this.Ulica = ulica;
			this.Grad = grad;
			this.Broj = broj;
			this.DatumRođenja = datumrođenja;
		}
		public ZaposleniView(long jmbg, string ime, string prezime, string ulica, string grad, int broj, DateTime datumrođenja, string mesto)
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
	public class ZaposleniDodaj
    {

    }
}
