using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class ZaposleniBrTelView
    {
        public ZaposleniBrTelId Id { get; set; }
        public ZaposleniBrTelView()
        {
        }

        internal ZaposleniBrTelView(ZaposleniBrTel b)
        {
            if (b != null)
            {
                Id = b.Id;

            }
        }
    }
}
