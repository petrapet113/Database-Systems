using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
	public class LekarView
	{
		public int Šifra { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public int BrojTelefona { get; set; }
		public IList<ReceptView> Recepti { get; set; }

		public LekarView()
		{
			Recepti = new List<ReceptView>();
		}

		internal LekarView(Lekar l)
		{
			if (l != null)
			{
				Šifra = l.Šifra;
				Ime = l.Ime;
				Prezime = l.Prezime;
				BrojTelefona = l.BrojTelefona;
			}

		}
	}
}
