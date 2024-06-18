using Microsoft.AspNetCore.Identity;
using PointSale.Models;
using System.Data;
using System.Data.SqlClient;

namespace PointSale.Data
{
    public class AdministracionBD
    {
        private readonly Context _contexto;

        public AdministracionBD()
        {
            _contexto = new Context("Server=LTELMXJCARCAMO\\SQL2014;Database=BD_Sale;User Id=sa;Password=telepro;MultipleActiveResultSets=true");
        }

        public List<Parametros> GetParametros(int IdParametro)
        {
            List<Parametros> parametros = new List<Parametros>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(_contexto.Conexion))
                {
                    using (SqlCommand comando = new SqlCommand("SpSel_Parametro", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add("@IdParametro", System.Data.SqlDbType.Int).Value = IdParametro;
                        conexion.Open();

                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read()) {
                            Parametros oParametro = new Parametros();
                            oParametro.IdParametro = reader.GetInt32(0);
                            oParametro.NomParametro = reader.GetString(1);
                            oParametro.DescParametro = reader.GetString(2);
                            oParametro.ParValor = reader.GetString(3);
                            oParametro.propiedadesControl.IdUsuario = reader.GetInt32(4);
                            oParametro.propiedadesControl.IdEstado = reader.GetInt32(5);
                            oParametro.propiedadesControl.Modificado = reader.GetDateTime(6);
                            oParametro.propiedadesControl.Creado = reader.GetDateTime(7);
                            parametros.Add(oParametro);
                        }
                        reader.Close();
                    }
                    conexion.Close();
                }
                return parametros;
            }
            catch (Exception ex) {
                return null;
            }
        }
    }
}
