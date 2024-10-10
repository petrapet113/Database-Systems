using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BazeProjekat.Entiteti
{
    public class Lek
    {
		public virtual int Id { get;  set; }
		public virtual string KomercijalniNaziv { get; set; }
		public virtual string HemijskiNaziv { get; set; }
		public virtual int DozaDeca { get; set; }
		public virtual int DozaOdrasli { get; set; }
		public virtual int DozaTrudnice { get; set; }
		public virtual int Cena { get; set; }
		public virtual PrimarnaGrupa JePrimarnaGrupa { get; set; }
		public virtual Proizvođač ProizvodiLek { get; set; }
		public virtual IList<Bolest> Bolesti { get; set; }
		public virtual IList<SeNalazi> SeNalaziProdajnaMesta { get; set; }
		public virtual IList<SePakuje> SePakujeVrstePakovanja { get; set; }
		public virtual IList<LekKontraindikacije> KontraindikacijeLekovi { get; set; }
		public virtual IList<LekNeželjeniEfekti> NeželjeniEfektiLekovi { get; set; }






		public Lek()
        {
			Bolesti = new List<Bolest>();
			SeNalaziProdajnaMesta = new List<SeNalazi>();
			SePakujeVrstePakovanja = new List<SePakuje>();
			KontraindikacijeLekovi = new List<LekKontraindikacije>();
			NeželjeniEfektiLekovi = new List<LekNeželjeniEfekti>();



		}




	}

}
