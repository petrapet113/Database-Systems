using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class LekKontraindikacijeView
    {
        public LekKontraindikacijeId Id { get; set; }
        public LekKontraindikacijeView()
        {

        }
        internal LekKontraindikacijeView(LekKontraindikacije k)
        {
            if (k != null)
            {
                Id = k.Id;

            }
        }
    }
}
