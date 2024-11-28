using PointSale.Entidades._06_Comunes;

namespace PointSale.Entidades._07_Catalogos
{
    public class CAT_PERFILES
    {
        public CAT_PERFILES() {
            COMUNES = new Comunes();
        }
        public int CPL_PK_ID { get; set; }
        public string CPL_DS_PERFIL { get; set; }
        public Comunes COMUNES { get; set; }
    }
}
