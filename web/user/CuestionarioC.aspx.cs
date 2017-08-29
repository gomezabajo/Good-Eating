using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _CuestionarioC : System.Web.UI.Page
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

            m.Num_fruta = Escape.getInt(HttpContext.Current.Request["num_fruta"]);
            if (m.Num_fruta > 1)
            {
                if (HttpContext.Current.Request["platano"] == "on")
                {
                    m.Platano = true;
                }
                if (HttpContext.Current.Request["cereza"] == "on")
                {
                    m.Cereza = true;
                }
                if (HttpContext.Current.Request["ciruela"] == "on")
                {
                    m.Ciruela = true;
                }
                if (HttpContext.Current.Request["guayaba"] == "on")
                {
                    m.Guayaba = true;
                }
                if (HttpContext.Current.Request["guanabana"] == "on")
                {
                    m.Guanabana = true;
                }
                if (HttpContext.Current.Request["higo"] == "on")
                {
                    m.Higo = true;
                }
                if (HttpContext.Current.Request["pera"] == "on")
                {
                    m.Pera = true;
                }
                if (HttpContext.Current.Request["albaricoque"] == "on")
                {
                    m.Albaricoque = true;
                }
                if (HttpContext.Current.Request["limon"] == "on")
                {
                    m.Limon = true;
                }
                if (HttpContext.Current.Request["naranja"] == "on")
                {
                    m.Naranja = true;
                }
                if (HttpContext.Current.Request["pinna"] == "on")
                {
                    m.Pinna = true;
                }
                if (HttpContext.Current.Request["tamarindo"] == "on")
                {
                    m.Tamarindo = true;
                }
                if (HttpContext.Current.Request["toronja"] == "on")
                {
                    m.Toronja = true;
                }
                if (HttpContext.Current.Request["uva"] == "on")
                {
                    m.Uva = true;
                }
                if (HttpContext.Current.Request["manzana"] == "on")
                {
                    m.Manzana = true;
                }
                if (HttpContext.Current.Request["melocoton"] == "on")
                {
                    m.Melocoton = true;
                }
                if (HttpContext.Current.Request["fresa"] == "on")
                {
                    m.Fresa = true;
                }
                if (HttpContext.Current.Request["mandarina"] == "on")
                {
                    m.Mandarina = true;
                }
                if (HttpContext.Current.Request["lima"] == "on")
                {
                    m.Lima = true;
                }
                if (HttpContext.Current.Request["aguacate"] == "on")
                {
                    m.Aguacate = true;
                }
                if (HttpContext.Current.Request["aceituna"] == "on")
                {
                    m.Aceituna = true;
                }
                if (HttpContext.Current.Request["avellana"] == "on")
                {
                    m.Avellana = true;
                }
                if (HttpContext.Current.Request["coco"] == "on")
                {
                    m.Coco = true;
                }
                if (HttpContext.Current.Request["nuez"] == "on")
                {
                    m.Nuez = true;
                }
                if (HttpContext.Current.Request["cacao"] == "on")
                {
                    m.Cacao = true;
                }
                if (HttpContext.Current.Request["durazno"] == "on")
                {
                    m.Durazno = true;
                }
            }
            if (HttpContext.Current.Request["lactosa"] == "lactosa_no")
            {
                m.Lactosa = true;
            }
            if (m.Lactosa == false)
            {
                m.Num_lactosa = Escape.getInt(HttpContext.Current.Request["num_lactosa"]);
            }

            Common.Modelado = m;
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }

        Response.Redirect("CuestionarioD.aspx");
    }
}