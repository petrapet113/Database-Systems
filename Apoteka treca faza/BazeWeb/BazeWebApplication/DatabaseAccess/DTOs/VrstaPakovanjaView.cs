using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class VrstaPakovanjaView
    {
		public int Id{get;  set;}
		public string Tip { get; set; }
		public IList<ReceptView> Recepti { get; set; }
		public IList<SePakujeView> SePakujeLekovi { get; set; }

		public VrstaPakovanjaView()
		{
			Recepti = new List<ReceptView>();
			SePakujeLekovi = new List<SePakujeView>();
		}

		internal VrstaPakovanjaView(VrstaPakovanja v)
		{
			if (v != null)
			{
				Id = v.Id;
				Tip = v.Tip;
			}
		}

	}
}
