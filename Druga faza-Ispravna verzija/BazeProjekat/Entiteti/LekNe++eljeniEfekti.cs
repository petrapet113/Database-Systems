using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekat.Entiteti
{
    public class LekNeželjeniEfekti
    {

        public virtual LekNeželjeniEfektiId Id { get; set; }

        public LekNeželjeniEfekti()
        {
            Id = new LekNeželjeniEfektiId();
        }
    }

}
