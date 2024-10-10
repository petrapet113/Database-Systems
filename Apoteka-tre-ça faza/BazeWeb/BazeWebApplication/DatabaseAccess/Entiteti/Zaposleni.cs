using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class Zaposleni
    {
		public virtual long JMBG { get; set; }
		public virtual string Ime { get; set; }
		public virtual string Prezime { get; set; }
		public virtual string Ulica { get; set; }
		public virtual int Broj { get; set; }
		public virtual string Grad { get; set; }
		public virtual DateTime DatumRođenja { get; set; }
		public virtual ProdajnoMesto RadiUProdMesto { get; set; }
		public virtual IList<ZaposleniBrTel> BrojeviTelefonaZaposlenog { get; set; }
		
		public Zaposleni()
        {
			BrojeviTelefonaZaposlenog = new List<ZaposleniBrTel>();

		}

        public Zaposleni(long jMBG, string ime, string prezime, string ulica, string grad, int broj, DateTime datumRođenja)
        {
            JMBG = jMBG;
            Ime = ime;
            Prezime = prezime;
            Ulica = ulica;
            Grad = grad;
            Broj = broj;
            DatumRođenja = datumRođenja;
        }
    }
}
