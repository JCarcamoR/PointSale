using PointSale.Entidades._06_Comunes;
using PointSale.Entidades._07_Catalogos;
using System.Collections.Generic;

namespace PointSale.Entidades._00_Sistema
{
    public class SYS_MENUS_PERFILES
    {
        public SYS_MENUS_PERFILES() {
            COMUNES = new Comunes();
            MENUS = new List<SYS_MENUS>();
            PERFILES = new List<CAT_PERFILES>();
        }
        public int SMP_PK_ID { get; set; }
        public Comunes COMUNES { get; set; }
        public List<CAT_PERFILES> PERFILES { get; set; }
        public List<SYS_MENUS> MENUS { get; set; }
    }
}
