using PointSale.Entidades._00_Sistema;
using PointSale.Entidades._06_Comunes;

public class SYS_MENUS
{
    public SYS_MENUS() { 
        COMUNES = new Comunes();
        OBJETOS = new SYS_OBJETOS();
        CONTROLADOR = new SYS_CONTROLADORES();
        METODO = new SYS_METODOS();
    }
    public int SMU_PK_ID {get; set;}
    public int SMU_CVE_PADRE {get; set;}
    public int SMU_CVE_ORDEN {get; set;}
    public string SMU_DS_TITULO {get; set;}
    public string SMU_DS_ICONO {get; set;}
    public SYS_CONTROLADORES CONTROLADOR { get; set;}
    public SYS_METODOS METODO { get; set;}
    public Comunes COMUNES { get; set; }
    public SYS_OBJETOS OBJETOS { get; set; }
}