using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekat.Entiteti
{
    public class Recept
    {
        public virtual int SerijskiBroj { get; protected set; }
        public virtual ProdajnoMesto RealizovanNa { get; set; }
        public virtual Lekar IzdajeRecept { get; set; }

        public virtual IList<VrstaPakovanja> VrstePakovanja { get; set; }
        public virtual IList<PrimarnaGrupa> PrimarneGrupe { get; set; }
        public virtual IList<Prepisan> PrepisanLekoviZaIzdavanje { get; set; }
        public virtual Farmaceut FarmaceutRealizuje { get; set; }

        public Recept()
        {
            VrstePakovanja = new List<VrstaPakovanja>();
            PrimarneGrupe = new List<PrimarnaGrupa>();
            PrepisanLekoviZaIzdavanje = new List<Prepisan>();
            

        }


    }
}
