using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class LekNeželjeniEfektiView
    {
        public LekNeželjeniEfektiId Id { get; set; }
        public LekNeželjeniEfektiView()
        {

        }
        internal LekNeželjeniEfektiView(LekNeželjeniEfekti ne)
        {
            if (ne != null)
            {
                Id = ne.Id;

            }
        }
    }
}
