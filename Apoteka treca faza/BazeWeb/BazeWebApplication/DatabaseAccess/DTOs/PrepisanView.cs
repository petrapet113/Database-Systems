using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
	public class PrepisanView
	{
		public PrepisanId Id { get; set; }
		public string Količina { get; set; }

		public PrepisanView()
		{ }
		internal PrepisanView(Prepisan p)
		{
			if (p != null)
			{
				Id = p.Id;
				Količina = p.Količina;
			}

		}
	}
}
