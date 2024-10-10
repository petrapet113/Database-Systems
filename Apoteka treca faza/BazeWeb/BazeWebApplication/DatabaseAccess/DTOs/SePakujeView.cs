using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SePakujeView
    {
		public SePakujeId Id { get; set; }
		public int Količina { get; set; }
		public string Sastav { get; set; }

		public SePakujeView()
		{
		}
		internal SePakujeView(SePakuje s)
		{
			if (s != null)
			{
				Id = s.Id;
				Količina = s.Količina;
				Sastav = s.Sastav;
			}
		}

	}
}
