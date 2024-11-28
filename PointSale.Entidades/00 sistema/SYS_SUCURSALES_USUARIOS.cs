using PointSale.Entidades._06_Comunes;
using PointSale.Entidades._07_Catalogos;

namespace PointSale.Entidades._00_Sistema
{
    public class SYS_SUCURSALES_USUARIOS
    {
        public SYS_SUCURSALES_USUARIOS()
        {
            COMUNES = new Comunes();
            USUARIOS = new SYS_USUARIOS();
            PERSONAS = new CAT_PERSONAS();
        }
        public int SSU_PK_ID { get; set; }
        public CAT_PERSONAS PERSONAS { get; set; }
        public SYS_USUARIOS USUARIOS { get; set; }
        public Comunes COMUNES { get; set; }
    }
}
