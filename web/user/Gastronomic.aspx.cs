using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Gastronomic : System.Web.UI.Page
{
    protected static Modelado m = null;
    protected static MenuDiario[] mdr = null;
    protected static int dias = 0;
    protected static DateTime hoy;

    protected static System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

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
        if (Common.Usuario.Acceso == "DESHABILITADO")
        {
            Response.Redirect("CuestionarioA.aspx");
        }
        try
        {
            m = Common.Modelado;
            hoy = DateTime.Now;
            mdr = null;
            dias = 0;
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }
    }
    protected void Generar_Click(object sender, EventArgs e)
    {
        dias = Escape.getInt(HttpContext.Current.Request["id_num_dias"]);
        if (dias > 0)
        {
            mdr = Recomendacion.MenuDiario(dias, m);
        }
    }
}
