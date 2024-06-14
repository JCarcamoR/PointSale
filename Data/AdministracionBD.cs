using Microsoft.AspNetCore.Identity;
using PointSale.Models;
using System.Data;
using System.Data.SqlClient;

namespace PointSale.Data
{
    public class AdministracionBD
    {
        private readonly Context _contexto;

        public AdministracionBD(Context contexto)
        {
            _contexto = contexto;
        }


        public List<Parametros> ConsultaParametosSistema(int IdParametro)
        {
            try
            {
                DataSet dsConsultaParametros = new DataSet();
                List<Parametros> parametros = new List<Parametros>();
                using (SqlConnection connection = new SqlConnection(_contexto.Conexion))
                {
                    using (SqlCommand command = new SqlCommand("SpSel_Parametro", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@IdParametro", System.Data.SqlDbType.Int).Value = IdParametro;
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();


                        while (reader.Read()) {
                            Parametros oParametro = new Parametros();
                            oParametro.IdParametro = reader.GetInt32(0);
                            oParametro.NomParametro = reader.GetString(1);
                            oParametro.DescParametro = reader.GetString(2);
                            oParametro.IdParPadre = reader.GetInt32(3);
                            oParametro.ParValor = reader.GetString(4);
                            oParametro.propiedadesControl.IdUsuario = reader.GetInt32(5);
                            oParametro.propiedadesControl.IdEstado = reader.GetInt32(6);
                            oParametro.propiedadesControl.Modificado = reader.GetDateTime(7);
                            oParametro.propiedadesControl.Creado = reader.GetDateTime(8);
                            parametros.Add(oParametro);
                        }
                        reader.Close();

                    }
                    connection.Close();
                }
                return parametros;
            }
            catch (Exception ex) {
                return null;
            }
        }




    }
}
