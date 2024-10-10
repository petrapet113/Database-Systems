using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SeNalaziView
    {
		public SeNalaziId Id { get; set; }
		public int Količina { get; set; }

		public SeNalaziView()
		{ }
		internal SeNalaziView(SeNalazi s)
		{
			if (s != null)
			{
				Id = s.Id;
				Količina = s.Količina;
			}
		}

	}
}
