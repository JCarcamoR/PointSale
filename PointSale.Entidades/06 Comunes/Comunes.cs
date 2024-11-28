using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSale.Entidades._06_Comunes
{
    public class Comunes
    {
        public Comunes() {
            MODIFICACIONES = new SYS_MODIFICACIONES();
            ESTADOS = new SYS_ESTADOS();
        }
        public SYS_MODIFICACIONES MODIFICACIONES { get; set; }
        public SYS_ESTADOS ESTADOS { get; set; }
    }
}
