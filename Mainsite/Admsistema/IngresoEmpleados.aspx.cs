﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mainsite.Admsistema
{
    public partial class IngresoEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NuevoCargo.NavigateUrl = "IngresoCargo.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);

        }

        protected void manual_CheckedChanged(object sender, EventArgs e)
        {
            if (manual.Checked == true)
            {
                txt_codigo.ReadOnly = false;
            }
            else
            {
                if (manual.Checked == false)
                {
                    txt_codigo.ReadOnly = true;
                }
            }
        }

        protected void Guardar(object sender, EventArgs e)
        {
            string nombres = txt_nombre.Text;
            string apellidos = txt_apellido.Text;
            string rut = txt_rut.Text;
            string digito = txt_rut.Text;
            string cargo = Convert.ToString(DDL_Cargo.SelectedValue);
            string codigo = txt_codigo.Text;
            string planta = Convert.ToString(DDL_Planta.SelectedValue);



        }

    }
}