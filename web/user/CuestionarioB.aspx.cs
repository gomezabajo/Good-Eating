using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _CuestionarioB : System.Web.UI.Page
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

            if (HttpContext.Current.Request["diabetes"] == "on")
            {
                m.Diabetes = true;
            }
            if (HttpContext.Current.Request["colesterol"] == "on")
            {
                m.Colesterol = true;
            }
            if (HttpContext.Current.Request["hepatica"] == "on")
            {
                m.Hepatica = true;
            }
            if (HttpContext.Current.Request["renal"] == "on")
            {
                m.Renal = true;
            }
            if (HttpContext.Current.Request["pancreas"] == "on")
            {
                m.Pancreas = true;
            }
            if (HttpContext.Current.Request["bilis"] == "on")
            {
                m.Bilis = true;
            }
            if (HttpContext.Current.Request["ulcera"] == "on")
            {
                m.Ulcera = true;
            }
            if (HttpContext.Current.Request["colitis"] == "on")
            {
                m.Colitis = true;
            }
            if (HttpContext.Current.Request["colon"] == "on")
            {
                m.Colon = true;
            }
            if (HttpContext.Current.Request["intestino"] == "on")
            {
                m.Intestino = true;
            }
            Common.Modelado = m;
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }

        Response.Redirect("CuestionarioC.aspx");
    }
}