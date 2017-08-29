using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Logout : System.Web.UI.Page
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

        try
        {
            // guarda el log
            Log l = new Log();
            l.Usuario = Common.Usuario;
            l.Operacion = "Logout";
            l.Fecha = Escape.getDateTimeAsString(System.DateTime.Now);
            l.Insertar();
        }
        catch
        {
            MsgBox.Show("No se pudo grabar el log de salida");
        }

        // cierra la sesión
        Common.SessionAbandon();
        return;
    }
}