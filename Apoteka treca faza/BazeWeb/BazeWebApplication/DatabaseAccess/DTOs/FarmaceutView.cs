using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
	public class FarmaceutView : ZaposleniView
	{
		public DateTime DatumObnoveLicence { get; set; }
		public DateTime DatumDiplomiranja { get; set; }
		public IList<ReceptView> RealizujeRecepte { get; set; }

		public FarmaceutView()
		{
			RealizujeRecepte = new List<ReceptView>();
		}

		internal FarmaceutView(Farmaceut f)
		{
			if (f != null)
			{
				DatumDiplomiranja = f.DatumDiplomiranja;
				DatumObnoveLicence = f.DatumObnoveLicence;
			}

		}
	}
}
