namespace PointSale.Models
{
    public class Parametros
    {   
        public Parametros()
        {
            propiedadesControl = new PropiedadesComunes;
        }

        public int IdParametro     {get; set;}
        public string NomParametro    {get; set;}
        public string DescParametro   {get; set;}
        public int IdParPadre      {get; set;}
        public string ParValor        {get; set;}
        
        public PropiedadesComunes propiedadesControl { get; set;}
    }
}
