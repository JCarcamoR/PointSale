using PointSale.Entidades._00_Sistema;
using PointSale.Entidades._06_Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSale.Entidades._07_Catalogos
{
    public class CAT_PERSONAS
    {
        public CAT_PERSONAS() {
            COMUNES = new Comunes();
            PERFILES = new CAT_PERFILES();
        }
        public int CPA_PK_ID { get; set; }
        public string CPA_DS_NOMBRE { get; set; }
        public string CPA_DS_APE_PAT { get; set; }
        public string CPA_DS_APE_MAT { get; set; }
        public DateTime CPA_FE_NAC { get; set; }
        public string CPA_DS_RFC { get; set; }
        public Comunes COMUNES { get; set; }
        public CAT_PERFILES PERFILES { get; set; }
    }
}
