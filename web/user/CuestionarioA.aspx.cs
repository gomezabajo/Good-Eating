using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _CuestionarioA : System.Web.UI.Page
{
    protected static List<Pais> lp = null;
    protected static List<Edad> led = null;

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
        try
        {
            Pais[] ap = Pais.Paises;
            if (ap != null)
            {
                lp = ap.ToList<Pais>();
            }
            Edad[] aed = Edad.Edades;
            if (aed != null)
            {
                led = aed.ToList<Edad>();
            }
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }
    }
    protected void Continuar_Click(object sender, EventArgs e)
    {
        try
        {
            Modelado m = Common.Modelado;

            if (HttpContext.Current.Request["gen"] == "1")
            {
                m.Genero = true;
            }

            int id_edad = Escape.getInt(HttpContext.Current.Request["id_edad"]);
            m.Edad = Edad.getById(id_edad);
            m.Estatura = Escape.getString(HttpContext.Current.Request["estatura"]);
            m.Peso = Escape.getString(HttpContext.Current.Request["peso"]);
            m.Num_comidas = Escape.getInt(HttpContext.Current.Request["id_num_comidas"]);
            m.Religion = HttpContext.Current.Request["religion"];
            int id_pais = Escape.getInt(HttpContext.Current.Request["id_pais"]);
            m.Pais = Pais.getById(id_pais);

            Common.Modelado = m;
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }
        Response.Redirect("CuestionarioB.aspx");
    }
}