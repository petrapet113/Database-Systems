using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
  
    	public class LekZaIzdavanjeView : LekView
		{
			public int ProcenatParticipacije { get; set; }
			public IList<PrepisanView> PrepisanRecepti { get; set; }

			public LekZaIzdavanjeView()
			{
				PrepisanRecepti = new List<PrepisanView>();
			}

			internal LekZaIzdavanjeView(LekZaIzdavanje l)
			{
				if (l != null)
				{
					ProcenatParticipacije = l.ProcenatParticipacije;

				}

			}
		}
	
}
