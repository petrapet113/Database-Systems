using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.Mapiranja
{
    class LekZaProdajuMapiranja : SubclassMap<LekZaProdaju>
    {
        public LekZaProdajuMapiranja()
        {
            Table("LEK_ZA_PRODAJU");

            KeyColumn("ID");


        }
    }
}
