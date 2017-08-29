using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.Odbc;

public partial class _Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // inicia la conexión a la base de datos
            Common.ActiveConnection.Create();
            if (Common.ActiveConnection.TryOpen() == false)
            {
                MsgBox.Show("Error on database access.");
                Common.ActiveConnection.TryClose();
                return;
            }
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }
    }
    protected void Acceso_Click(object sender, EventArgs e)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;

        string query = string.Empty;

        try
        {
            if (Common.ActiveConnection.TryOpen() == false)
            {
                Common.ActiveConnection.TryClose();
                return;
            }

            // comprueba que el usuario y la contraseña son correctos
            query = "SELECT VN_USER.LOGIN FROM VN_USER " +
                        "WHERE VN_USER.LOGIN = '" + HttpContext.Current.Request["usuario"] + "' " +
                        "AND VN_USER.PASSWORD = '" + HttpContext.Current.Request["clave"] + "' " +
                        "AND VN_USER.AREA = 'admin' " +
                        "AND (VN_USER.DATE_REMOVED IS NULL OR VN_USER.DATE_REMOVED = '')";

            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            da.Dispose();
            Common.ActiveConnection.TryClose();
        }

        catch (Exception ex)
        {
            if (da != null)
            {
                da.Dispose();
            }

            Common.ActiveConnection.TryClose();
            MsgBox.Show("Error on database access: " + ex.Message);
            return;
        }

        // si el login fue correcto comprueba el usuario y redirige a la página correspondiente
        if (dt.Rows.Count == 0)
        {
            if (da != null)
            {
                da.Dispose();
            }
            Common.ActiveConnection.TryClose();
            MsgBox.Show("Denied access");
            return;
        }

        // guarda la variable de sesión
        Common.Usuario = Usuario.getByLogin(Escape.getString(dt.Rows[0][0]));

        // guarda el log
        Log l = new Log();
        l.Usuario = Common.Usuario;
        l.Operacion = "Access";
        l.Fecha = Escape.getDateTimeAsString(System.DateTime.Now);
        l.Insertar();

        Response.Redirect("Menu.aspx");
    }
}
