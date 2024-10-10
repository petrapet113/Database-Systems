using System;
using System.Collections.Generic;
using System.Text;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ProdajnoMestoView
    {
		public string Naziv { get; set; }
		public int Id { get; set; }
		public string Ulica { get; set; }
		public string Grad { get; set; }
		public int Broj { get; set; }
		public virtual IList<Zaposleni> Zaposleni { get; set; }
		public virtual IList<Recept> Recepti { get; set; }

		public ProdajnoMestoView()
		{
			Zaposleni = new List<Zaposleni>();
			Recepti = new List<Recept>();
		}
		//public ProdajnoMestoView()
  //      {

  //      }
		public ProdajnoMestoView(int id, string naziv, string ulica, string grad, int broj)
		{
			this.Id = id;
			this.Naziv = naziv;
			this.Ulica = ulica;
			this.Grad = grad;
			this.Broj = broj;
		}

        public ProdajnoMestoView(ProdajnoMesto p)
        {
        }
    }
}
