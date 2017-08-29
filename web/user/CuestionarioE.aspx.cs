using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _CuestionarioE : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Common.Usuario == null)
        {
            Common.SessionAbandon();
            return;
        }
        if ((Common.Usuario.Login == string.Empty) || (Usuario.User.Contains(Common.Usuario) == false))
        {
            Common.SessionAbandon();
            return;
        }
    }
    protected void Finalizar_Click(object sender, EventArgs e)
    {
        try
        {
            Modelado m = Common.Modelado;

            if (HttpContext.Current.Request["huevos"] == "on")
            {
                m.Huevos = true;
            }
            if (HttpContext.Current.Request["pan"] == "on")
            {
                m.Pan = true;
            }
            if (HttpContext.Current.Request["arroz"] == "on")
            {
                m.Arroz = true;
            }
            if (HttpContext.Current.Request["pasta"] == "on")
            {
                m.Pasta = true;
            }
            if (HttpContext.Current.Request["tipo"] == "1")
            {
                m.Tipo = true;
            }
            if (m.Tipo == false)
            {
                if (HttpContext.Current.Request["pescado"] == "on")
                {
                    m.Pescado = true;
                }
                if (HttpContext.Current.Request["carne"] == "on")
                {
                    m.Carne = true;
                }
                if (HttpContext.Current.Request["pollo"] == "on")
                {
                    m.Pollo = true;
                }
            }
            m.Estilo = Escape.getInt(HttpContext.Current.Request["estilo"]);
            m.Presupuesto = Escape.getInt(HttpContext.Current.Request["presupuesto"]);

            Common.Modelado = m;
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }

        // al terminar el cuestionario actualiza la base de datos
        Common.Modelado.Insertar();

        Common.Usuario.Acceso = "HABILITADO";
        Common.Usuario.Actualizar();

        Response.Redirect("Menu.aspx");
    }
}