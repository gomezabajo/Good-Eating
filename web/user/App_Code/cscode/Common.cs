using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

using System.Linq;
using System.Web;

public class Common
{
    private static MySqlConnection _sc = new MySqlConnection();
    private static SessionStack _ps = new SessionStack();

    public static MySqlConnection ActiveConnection
    {
        get { return _sc; }
    }

    public static Usuario Usuario
    {
        get
        {
            if (HttpContext.Current.Session["USUARIO"] != null)
            {
                return (Usuario)HttpContext.Current.Session["USUARIO"];
            }
            else
            {
                return null;
            }
        }
        set { HttpContext.Current.Session["USUARIO"] = value; }
    }

    public static Modelado Modelado
    {
        get
        {
            if (HttpContext.Current.Session["MODELADO"] != null)
            {
                return (Modelado)HttpContext.Current.Session["MODELADO"];
            }
            else
            {
                return null;
            }
        }
        set { HttpContext.Current.Session["MODELADO"] = value; }
    }

    public static void SessionAbandon()
    {
        ActiveConnection.TryClose();
        ActiveConnection.Dispose();
        _ps.Delete("PageStack");
        HttpContext.Current.Session.Abandon();
        HttpContext.Current.Response.Redirect("Login.aspx");
    }

    public Common()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
