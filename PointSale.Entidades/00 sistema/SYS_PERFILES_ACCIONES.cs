using PointSale.Entidades._07_Catalogos;
using PointSale.Entidades._06_Comunes;
using System.Collections.Generic;

namespace PointSale.Entidades._00_Sistema
{
    public class SYS_PERFILES_ACCIONES
    {
        public SYS_PERFILES_ACCIONES()
        {
            COMUNES = new Comunes();
            PERFILES = new CAT_PERFILES();
            MENUS = new List<SYS_MENUS>();
            ACCIONES = new List<SYS_ACCIONES>();
        }
        public int SPA_PK_ID { get; set;}
        public Comunes COMUNES { get; set; }
        public CAT_PERFILES PERFILES { get; set; }
        public List<SYS_MENUS> MENUS { get; set; }
        public List<SYS_ACCIONES> ACCIONES { get; set; }
    }
}
