using PointSale.Entidades._06_Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSale.Entidades._00_Sistema
{
    public class SYS_METODOS
    {
        public SYS_METODOS()
        {
            comunes = new Comunes();
        }

        public int SMO_PK_ID { get; set; }
        public string SMO_DS_METODO { get; set; }
        public Comunes comunes {  get; set; }
    }
}
