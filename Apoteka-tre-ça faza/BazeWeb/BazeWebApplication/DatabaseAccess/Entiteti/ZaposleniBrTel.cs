using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class ZaposleniBrTel
    {

        public virtual ZaposleniBrTelId Id { get; set; }

        public ZaposleniBrTel()
        {
            Id = new ZaposleniBrTelId();
        }
    }

}
