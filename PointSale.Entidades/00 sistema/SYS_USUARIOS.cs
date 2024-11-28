using PointSale.Entidades._06_Comunes;
using PointSale.Entidades._07_Catalogos;

namespace PointSale.Entidades._00_Sistema
{
    public class SYS_USUARIOS
    {
        public SYS_USUARIOS() {
            COMUNES = new Comunes();
            PERSONAS = new CAT_PERSONAS();
        }
        public int SUO_PK_ID { get; set; }
        public string SUO_DS_CLAVE { get; set; }
        public string SUO_DS_PWORD { get; set; }
        public string SUO_DS_FIRMA { get; set; }
        public string SUO_FE_UACCESO { get; set; }
        public string SUO_HR_UACCESO { get; set; }
        public string SUO_FE_REGISTRO { get; set; }
        public Comunes COMUNES { get; set; }
        public CAT_PERSONAS PERSONAS { get; set; }
    }
}
