namespace PointSale.Data
{
    public class Context
    {
        public string Conexion { get; set; }

        public Context(string value)
        {
            Conexion = value;
        }


    }
}
