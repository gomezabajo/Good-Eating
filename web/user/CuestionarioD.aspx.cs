using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _CuestionarioD : System.Web.UI.Page
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
    protected void Continuar_Click(object sender, EventArgs e)
    {
        try
        {
            Modelado m = Common.Modelado;

            m.Num_verd = Escape.getInt(HttpContext.Current.Request["num_verd"]);
            if (m.Num_verd > 1)
            {
                if (HttpContext.Current.Request["esparrago"] == "on")
                {
                    m.Esparrago = true;
                }
                if (HttpContext.Current.Request["espinaca"] == "on")
                {
                    m.Espinaca = true;
                }
                if (HttpContext.Current.Request["acelga"] == "on")
                {
                    m.Acelga = true;
                }
                if (HttpContext.Current.Request["cardo"] == "on")
                {
                    m.Cardo = true;
                }
                if (HttpContext.Current.Request["borraja"] == "on")
                {
                    m.Borraja = true;
                }
                if (HttpContext.Current.Request["lechuga"] == "on")
                {
                    m.Lechuga = true;
                }
                if (HttpContext.Current.Request["pepinillo"] == "on")
                {
                    m.Pepinillo = true;
                }
                if (HttpContext.Current.Request["tomate"] == "on")
                {
                    m.Tomate = true;
                }
                if (HttpContext.Current.Request["pimiento"] == "on")
                {
                    m.Pimiento = true;
                }
                if (HttpContext.Current.Request["berenjena"] == "on")
                {
                    m.Berenjena = true;
                }
                if (HttpContext.Current.Request["calabacin"] == "on")
                {
                    m.Calabacin = true;
                }
                if (HttpContext.Current.Request["alcachofa"] == "on")
                {
                    m.Alcachofa = true;
                }
                if (HttpContext.Current.Request["puerro"] == "on")
                {
                    m.Puerro = true;
                }
                if (HttpContext.Current.Request["ajo"] == "on")
                {
                    m.Ajo = true;
                }
                if (HttpContext.Current.Request["cebolla"] == "on")
                {
                    m.Cebolla = true;
                }
                if (HttpContext.Current.Request["nabo"] == "on")
                {
                    m.Nabo = true;
                }
                if (HttpContext.Current.Request["patata"] == "on")
                {
                    m.Patata = true;
                }
                if (HttpContext.Current.Request["rabanos"] == "on")
                {
                    m.Rabanos = true;
                }
                if (HttpContext.Current.Request["remolacha"] == "on")
                {
                    m.Remolacha = true;
                }
                if (HttpContext.Current.Request["zanahoria"] == "on")
                {
                    m.Zanahoria = true;
                }
                if (HttpContext.Current.Request["judias"] == "on")
                {
                    m.Judias = true;
                }
                if (HttpContext.Current.Request["guisantes"] == "on")
                {
                    m.Guisantes = true;
                }
                if (HttpContext.Current.Request["lentejas"] == "on")
                {
                    m.Lentejas = true;
                }
                if (HttpContext.Current.Request["alubias"] == "on")
                {
                    m.Alubias = true;
                }
                if (HttpContext.Current.Request["repollo"] == "on")
                {
                    m.Repollo = true;
                }
                if (HttpContext.Current.Request["brecol"] == "on")
                {
                    m.Brecol = true;
                }
                if (HttpContext.Current.Request["coles"] == "on")
                {
                    m.Coles = true;
                }
                if (HttpContext.Current.Request["coliflor"] == "on")
                {
                    m.Coliflor = true;
                }
                if (HttpContext.Current.Request["champinnon"] == "on")
                {
                    m.Champinnon = true;
                }
                if (HttpContext.Current.Request["setas"] == "on")
                {
                    m.Setas = true;
                }
            }

            Common.Modelado = m;
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }

        Response.Redirect("CuestionarioE.aspx");
    }
}