using PointSale.Entidades._06_Comunes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSale.Entidades._00_Sistema
{
    public class SYS_CONTROLADORES
    {
        public SYS_CONTROLADORES() 
        { 
            comunes = new Comunes();
        }
        public int SCR_PK_ID { get; set; }
        public string SCR_DS_CONTROLADOR { get; set; }
        public Comunes comunes { get; set; }
    }
}
