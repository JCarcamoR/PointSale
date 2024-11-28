using PointSale.Entidades._06_Comunes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PointSale.Datos._00_Sistema
{
    public class MenuData
    {
        #region PropiedadesPublicas
        public List<SYS_MENUS> ltsMenus { get; }
        public Error error { get; }
        #endregion

        #region VariablesPrivadas
        private PointSaleBD _bd;
        #endregion

        #region Constructores
        public MenuData()
        {
            ltsMenus = new List<SYS_MENUS>();
            _bd = new PointSaleBD();
            error = new Error();
        }
        #endregion

        public void ObtenerMenusPerfil(string perfil)
        {
            try
            {
                using (var conexion = new SqlConnection(_bd.cadenaConexion))
                {
                    conexion.Open();
                    using (var comando = new SqlCommand("Sp_Sel_01_Menus", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@CPL_DS_PERFIL", perfil);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector != null && lector.HasRows)
                            {
                                var menu = new SYS_MENUS();

                                while (lector.Read())
                                {
                                    menu.SMU_PK_ID = lector.GetInt32(0);
                                    menu.OBJETOS.SOO_PK_ID = lector.GetInt32(1);
                                    menu.SMU_CVE_PADRE = lector.GetInt32(2);
                                    menu.SMU_CVE_ORDEN = lector.GetInt32(3);
                                    menu.SMU_DS_TITULO = lector.GetString(4);
                                    menu.SMU_DS_ICONO = lector.GetString(5);
                                    menu.CONTROLADOR.SCR_DS_CONTROLADOR = lector.GetString(6);
                                    menu.METODO.SMO_DS_METODO = lector.GetString(7);
                                    ltsMenus.Add(menu);
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                error.EsError = true;
                error.MensajeError = ex.ToString();
            }
        }
    }
}
