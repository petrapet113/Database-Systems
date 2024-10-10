using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ReceptView
    {
		public int SerijskiBroj { get; set; }
		public ProdajnoMesto RealizovanNa { get; set; }
		public Lekar IzdajeRecept { get; set; }
		public Farmaceut FarmaceutRealizuje { get; set; }
		public string ImeLekara { get; set; }
		public string ImeFarmaceuta { get; set; }
		public string PrezimeLekara { get; set; }
		public string PrezimeFarmaceuta { get; set; }
		public string PrepisanLek { get; set; }

		public virtual List<string> primarnegrupe { get; set; }
		public virtual List<string> vrstepakovanja { get; set; }

		public virtual IList<VrstaPakovanjaView> VrstePakovanja { get; set; }
		public virtual IList<PrimarnaGrupaView> PrimarnaGrupa { get; set; }
		public virtual IList<PrepisanView> PrepisanLekoviZaIzdavanje { get; set; }

		public ReceptView()
		{
			primarnegrupe = new List<string>();
			vrstepakovanja = new List<string>();
			VrstePakovanja = new List<VrstaPakovanjaView>();
			PrimarnaGrupa = new List<PrimarnaGrupaView>();
			//PrepisanLekoviZaIzdavanje = new List<PrepisanView>(); //nemamo nigde prepisanView
		}
		public ReceptView(int serijskibroj, string imeL, string imeF, string pL, string pF)
		{

			this.SerijskiBroj = serijskibroj;
			ImeLekara = imeL;
			ImeFarmaceuta = imeF;
			PrezimeFarmaceuta = pF;
			PrezimeLekara = pL;


		}

		internal ReceptView(ReceptView r)
		{
			if (r != null)
			{
				SerijskiBroj = r.SerijskiBroj;
				RealizovanNa = r.RealizovanNa;
				IzdajeRecept = r.IzdajeRecept;
				FarmaceutRealizuje = r.FarmaceutRealizuje;
				ImeLekara = r.ImeLekara;
				ImeFarmaceuta = r.ImeFarmaceuta;
				PrezimeLekara = r.PrezimeLekara;
				PrezimeFarmaceuta = r.PrezimeFarmaceuta;
				PrepisanLek = r.PrepisanLek;

			}
		}
	}
}
