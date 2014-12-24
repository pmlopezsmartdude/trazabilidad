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



namespace Mainsite.Admsistema
{
    public partial class impresoras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenMachineConfiguration("/WTCSolutions");
            System.Configuration.ConnectionStringSettings trazabilidad;
            trazabilidad = rootWebConfig.ConnectionStrings.ConnectionStrings["trazabilidad"];

        }
 
 
    }  
}