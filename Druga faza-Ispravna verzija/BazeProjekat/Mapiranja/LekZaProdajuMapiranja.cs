using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BazeProjekat.Entiteti;

namespace BazeProjekat.Mapiranja
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
