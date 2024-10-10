using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ProizvođačView
    {
		public int Id { get; set; }
		public string Naziv { get; set; }
		public IList<LekView> Lekovi { get; set; }

		public ProizvođačView()
		{
			Lekovi = new List<LekView>();
		}

		internal ProizvođačView(Proizvođač p)
		{
			if (p != null)
			{
				Id = p.Id;
				Naziv = p.Naziv;
			}
		}

	}
}
