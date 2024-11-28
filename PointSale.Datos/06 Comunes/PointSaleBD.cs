using PointSale.Datos._00_Sistema;
using System;
using System.Data;
using System.Data.SqlClient;

public class PointSaleBD
{
    private APP_SETTINGS SETTINGS;

    public string cadenaConexion;
    public PointSaleBD()
    {
        SETTINGS = new APP_SETTINGS();
        cadenaConexion = SETTINGS.CadenaConexion;
    }
}
