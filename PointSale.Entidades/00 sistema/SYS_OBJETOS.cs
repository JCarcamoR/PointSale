using PointSale.Entidades._06_Comunes;
using System;

namespace PointSale.Entidades._00_Sistema
{
    public class SYS_OBJETOS
    {
        public SYS_OBJETOS() {
            COMUNES = new Comunes();
        }
        public int SOO_PK_ID { get; set; }

        public string SOO_DS_TIPO { get; set; }
        public Comunes COMUNES { get; set; }
    }
}
