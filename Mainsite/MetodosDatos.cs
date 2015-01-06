using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Mainsite
{
    public class MetodosDatos
    {
 
        public static SqlCommand CrearComando()
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/WTCSolutions");
            System.Configuration.ConnectionStringSettings connStringTrazabilidad;
            connStringTrazabilidad = rootWebConfig.ConnectionStrings.ConnectionStrings["trazabilidad"];
            SqlConnection _conexion = new SqlConnection(connStringTrazabilidad.ToString());
            _conexion.ConnectionString = connStringTrazabilidad.ToString();
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;
        }
        public static SqlCommand CrearCommandoProc(string proc)
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/WTCSolutions");
            System.Configuration.ConnectionStringSettings connStringTrazabilidad;
            connStringTrazabilidad = rootWebConfig.ConnectionStrings.ConnectionStrings["trazabilidad"];
            SqlConnection _conexion = new SqlConnection(connStringTrazabilidad.ToString());
            SqlCommand _comando = new SqlCommand(proc, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }
        public static int EjecutarComando(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { comando.Connection.Close(); }
            return _tabla;
        }
  
    }
 }