﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Registro : System.Web.UI.Page
{
    protected static List<Familia> lfam = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Familia[] afam = Familia.Familias;
            if (afam != null)
            {
                lfam = afam.ToList<Familia>();
            }
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }
    }
    protected void Insertar_Click(object sender, EventArgs e)
    {
        try
        {
            // datos del usuario
            Usuario u = new Usuario();
            u.Area = "user";
            u.Alta = Escape.getDateAsString(System.DateTime.Now);
            u.Login = HttpContext.Current.Request["usuario"];
            if (u.Login == string.Empty)
            {
                throw new Exception("Not valid username");
            }
            string clave_user = HttpContext.Current.Request["clave_rep"];
            if (clave_user == string.Empty)
            {
                throw new Exception("Not valid password");
            }
            if (u.Clave == string.Empty)
            {
                throw new Exception("Not valid password");
            }
            u.Clave = HttpContext.Current.Request["clave"];
            if (u.Clave != clave_user)
            {
                throw new Exception("Passwords do not match");
            }
            u.Nombre = HttpContext.Current.Request["nombre_user"];
            if (u.Nombre == string.Empty)
            {
                throw new Exception("Not valid complete name");
            }
            u.Apellidos = HttpContext.Current.Request["apellidos_user"];
            if (u.Apellidos == string.Empty)
            {
                throw new Exception("Not valid surname");
            }
            u.Email = HttpContext.Current.Request["email_user"];
            if (Escape.IsValidEmail(u.Email) != true)
            {
                throw new Exception("Not valid e-mail");
            }
            u.Notas = HttpContext.Current.Request["notas_user"];
            u.Fec_baja = null;
            u.Acceso = "DESHABILITADO";

            // datos de la familia
            string fam = HttpContext.Current.Request.Form["fam"];
            Familia f = null;
            //si se va a crear una familia nueva
            if (fam == "fam_new")
            {
                f = new Familia();
                f.Nombre = HttpContext.Current.Request["nombre_fam"];
                if (f.Nombre == string.Empty)
                {
                    throw new Exception("Not valid family name");
                }
                string clave_fam = HttpContext.Current.Request["clave_fam_rep"];
                if (clave_fam == string.Empty)
                {
                    throw new Exception("Not valid family password");
                }
                f.Clave = HttpContext.Current.Request["clave_fam"];
                if (f.Clave == string.Empty)
                {
                    throw new Exception("Not valid family password");
                }
                if (f.Clave != clave_fam)
                {
                    throw new Exception("Family passwords do not match");
                }
                f.Email = HttpContext.Current.Request["email_fam"];
                if (Escape.IsValidEmail(f.Email) != true)
                {
                    throw new Exception("Not valid family e-mail");
                }
                f.Notas = HttpContext.Current.Request["notas_fam"];
                f.Insertar();
            }
            //si se va a incluir al usuario en una familia existente
            if (fam == "fam_saved")
            {
                int id_familia = Escape.getInt(HttpContext.Current.Request["id_fam"]);
                f = Familia.getById(id_familia);
                string clave_fam = HttpContext.Current.Request["clave_fam_check"];
                if (f.Clave != clave_fam)
                {
                    throw new Exception("Family passwords do not match");
                }
            }

            if (f == null)
            {
                throw new Exception("Not created or assigned family");
            }
            u.Familia = f;
            u.Insertar();

            // guarda la variable de sesión
            Common.Usuario = u;

            // guarda el log
            Log l = new Log();
            l.Usuario = Common.Usuario;
            l.Operacion = "Acceso";
            l.Fecha = Escape.getDateTimeAsString(System.DateTime.Now);
            l.Insertar();

            Response.Redirect("Menu.aspx");

        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }
    }
}
