using PointSale.Entidades._06_Comunes;

namespace PointSale.Entidades._00_Sistema
{
    public class SYS_ACCIONES
    {
        public SYS_ACCIONES() {
            COMUNES = new Comunes();
        }
        public int SAN_PK_ID { get; set; }
        public string SAN_DS_ACCION { get; set; }
        public Comunes COMUNES { get; set; }
    }
}
