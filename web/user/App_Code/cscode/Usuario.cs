using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario : IEquatable<Usuario>, IComparable<Usuario>
{
    public int Id;
    public string Alta;
    public string Baja;
    public string Tipo;
    public string Nombre;
    public string Apellidos;
    public string Email;
    public string Login;
    public string Clave;
    public string Notas;
    public string Fec_baja;
    public string Fec_mod;
    public int Id_mod;
    public Familia Familia;
    public string Area;
    public string Acceso;

    public static Usuario[] Usuarios
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Usuario> us = new List<Usuario>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_USER.ID_USER, VN_USER.NEW_USER, VN_USER.REMOVED_USER, VN_USER.TYPE_USER, " +
                                "VN_USER.NAME_USER, VN_USER.SURNAMES_USER, VN_USER.EMAIL_USER, " +
                                "VN_USER.LOGIN, VN_USER.PASSWORD, VN_USER.NOTES_USER, VN_USER.DATE_REMOVED, VN_USER.DATE_USER_MOD, " +
                                "VN_USER.ID_USER_MOD, VN_USER.ID_FAMILY, VN_USER.AREA, VN_USER.VN_ACCESS " +
                                "FROM VN_USER " +
                                "ORDER BY VN_USER.AREA DESC, VN_USER.SURNAMES_USER, VN_USER.NAME_USER, VN_USER.LOGIN";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Usuario u = new Usuario();
                        u.Id = Escape.getInt(dt.Rows[i][0]);
                        u.Alta = Escape.getString(dt.Rows[i][1]);
                        u.Baja = Escape.getString(dt.Rows[i][2]);
                        u.Tipo = Escape.getString(dt.Rows[i][3]);
                        u.Nombre = Escape.getString(dt.Rows[i][4]);
                        u.Apellidos = Escape.getString(dt.Rows[i][5]);
                        u.Email = Escape.getString(dt.Rows[i][6]);
                        u.Login = Escape.getString(dt.Rows[i][7]);
                        u.Clave = Escape.getString(dt.Rows[i][8]);
                        u.Notas = Escape.getString(dt.Rows[i][9]);
                        u.Fec_baja = Escape.getString(dt.Rows[i][10]);
                        u.Fec_mod = Escape.getString(dt.Rows[i][11]);
                        u.Id_mod = Escape.getInt(dt.Rows[i][12]);
                        int idfamilia = -1;
                        if (int.TryParse(Escape.getString(dt.Rows[i][13]), out idfamilia) != false)
                        {
                            u.Familia = Familia.getById(idfamilia);
                        }
                        else
                        {
                            u.Familia = null;
                        }
                        u.Area = Escape.getString(dt.Rows[i][14]);
                        u.Acceso = Escape.getString(dt.Rows[i][15]);

                        us.Add(u);
                    }
                }
            }
            catch
            {
                if (da != null)
                {
                    da.Dispose();
                }
                throw;
            }
            return us.ToArray<Usuario>();
        }
    }

    public static Usuario[] Sistema
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Usuario> us = new List<Usuario>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_USER.ID_USER, VN_USER.NEW_USER, VN_USER.REMOVED_USER, VN_USER.TYPE_USER, " +
                               "VN_USER.NAME_USER, VN_USER.SURNAMES_USER, VN_USER.EMAIL_USER, " +
                               "VN_USER.LOGIN, VN_USER.PASSWORD, VN_USER.NOTES_USER, VN_USER.DATE_REMOVED, VN_USER.DATE_USER_MOD, " +
                               "VN_USER.ID_USER_MOD, VN_USER.ID_FAMILY, VN_USER.AREA, VN_USER.VN_ACCESS " +
                               "FROM VN_USER " +
                                "WHERE VN_USER.AREA = 'admin' " +
                                "ORDER BY VN_USER.AREA DESC, VN_USER.SURNAMES_USER, VN_USER.NAME_USER, VN_USER.LOGIN";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Usuario u = new Usuario();
                        u.Id = Escape.getInt(dt.Rows[i][0]);
                        u.Alta = Escape.getString(dt.Rows[i][1]);
                        u.Baja = Escape.getString(dt.Rows[i][2]);
                        u.Tipo = Escape.getString(dt.Rows[i][3]);
                        u.Nombre = Escape.getString(dt.Rows[i][4]);
                        u.Apellidos = Escape.getString(dt.Rows[i][5]);
                        u.Email = Escape.getString(dt.Rows[i][6]);
                        u.Login = Escape.getString(dt.Rows[i][7]);
                        u.Clave = Escape.getString(dt.Rows[i][8]);
                        u.Notas = Escape.getString(dt.Rows[i][9]);
                        u.Fec_baja = Escape.getString(dt.Rows[i][10]);
                        u.Fec_mod = Escape.getString(dt.Rows[i][11]);
                        u.Id_mod = Escape.getInt(dt.Rows[i][12]);
                        int idfamilia = -1;
                        if (int.TryParse(Escape.getString(dt.Rows[i][13]), out idfamilia) != false)
                        {
                            u.Familia = Familia.getById(idfamilia);
                        }
                        else
                        {
                            u.Familia = null;
                        }
                        u.Area = Escape.getString(dt.Rows[i][14]);
                        u.Acceso = Escape.getString(dt.Rows[i][15]);

                        us.Add(u);
                    }
                }
            }
            catch
            {
                if (da != null)
                {
                    da.Dispose();
                }
                throw;
            }
            return us.ToArray<Usuario>();
        }
    }

    public static Usuario[] User
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Usuario> us = new List<Usuario>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_USER.ID_USER, VN_USER.NEW_USER, VN_USER.REMOVED_USER, VN_USER.TYPE_USER, " +
                               "VN_USER.NAME_USER, VN_USER.SURNAMES_USER, VN_USER.EMAIL_USER, " +
                               "VN_USER.LOGIN, VN_USER.PASSWORD, VN_USER.NOTES_USER, VN_USER.DATE_REMOVED, VN_USER.DATE_USER_MOD, " +
                               "VN_USER.ID_USER_MOD, VN_USER.ID_FAMILY, VN_USER.AREA, VN_USER.VN_ACCESS " +
                               "FROM VN_USER " +
                                "WHERE VN_USER.AREA = 'user' " +
                                "ORDER BY VN_USER.AREA DESC, VN_USER.SURNAMES_USER, VN_USER.NAME_USER, VN_USER.LOGIN";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Usuario u = new Usuario();
                        u.Id = Escape.getInt(dt.Rows[i][0]);
                        u.Alta = Escape.getString(dt.Rows[i][1]);
                        u.Baja = Escape.getString(dt.Rows[i][2]);
                        u.Tipo = Escape.getString(dt.Rows[i][3]);
                        u.Nombre = Escape.getString(dt.Rows[i][4]);
                        u.Apellidos = Escape.getString(dt.Rows[i][5]);
                        u.Email = Escape.getString(dt.Rows[i][6]);
                        u.Login = Escape.getString(dt.Rows[i][7]);
                        u.Clave = Escape.getString(dt.Rows[i][8]);
                        u.Notas = Escape.getString(dt.Rows[i][9]);
                        u.Fec_baja = Escape.getString(dt.Rows[i][10]);
                        u.Fec_mod = Escape.getString(dt.Rows[i][11]);
                        u.Id_mod = Escape.getInt(dt.Rows[i][12]);
                        int idfamilia = -1;
                        if (int.TryParse(Escape.getString(dt.Rows[i][13]), out idfamilia) != false)
                        {
                            u.Familia = Familia.getById(idfamilia);
                        }
                        else
                        {
                            u.Familia = null;
                        }
                        u.Area = Escape.getString(dt.Rows[i][14]);
                        u.Acceso = Escape.getString(dt.Rows[i][15]);

                        us.Add(u);
                    }
                }
            }
            catch
            {
                if (da != null)
                {
                    da.Dispose();
                }
                throw;
            }
            return us.ToArray<Usuario>();
        }
    }

    public static Usuario[] Bajas
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Usuario> us = new List<Usuario>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_USER.ID_USER, VN_USER.NEW_USER, VN_USER.REMOVED_USER, VN_USER.TYPE_USER, " +
                               "VN_USER.NAME_USER, VN_USER.SURNAMES_USER, VN_USER.EMAIL_USER, " +
                               "VN_USER.LOGIN, VN_USER.PASSWORD, VN_USER.NOTES_USER, VN_USER.DATE_REMOVED, VN_USER.DATE_USER_MOD, " +
                               "VN_USER.ID_USER_MOD, VN_USER.ID_FAMILY, VN_USER.AREA, VN_USER.VN_ACCESS " +
                               "FROM VN_USER " +
                                "WHERE (VN_USER.DATE_REMOVED IS NOT NULL AND NOT VN_USER.DATE_REMOVED = '') " +
                                "ORDER BY VN_USER.AREA DESC, VN_USER.SURNAMES_USER, VN_USER.NAME_USER, VN_USER.LOGIN";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Usuario u = new Usuario();
                        u.Id = Escape.getInt(dt.Rows[i][0]);
                        u.Alta = Escape.getString(dt.Rows[i][1]);
                        u.Baja = Escape.getString(dt.Rows[i][2]);
                        u.Tipo = Escape.getString(dt.Rows[i][3]);
                        u.Nombre = Escape.getString(dt.Rows[i][4]);
                        u.Apellidos = Escape.getString(dt.Rows[i][5]);
                        u.Email = Escape.getString(dt.Rows[i][6]);
                        u.Login = Escape.getString(dt.Rows[i][7]);
                        u.Clave = Escape.getString(dt.Rows[i][8]);
                        u.Notas = Escape.getString(dt.Rows[i][9]);
                        u.Fec_baja = Escape.getString(dt.Rows[i][10]);
                        u.Fec_mod = Escape.getString(dt.Rows[i][11]);
                        u.Id_mod = Escape.getInt(dt.Rows[i][12]);
                        int idfamilia = -1;
                        if (int.TryParse(Escape.getString(dt.Rows[i][13]), out idfamilia) != false)
                        {
                            u.Familia = Familia.getById(idfamilia);
                        }
                        else
                        {
                            u.Familia = null;
                        }
                        u.Area = Escape.getString(dt.Rows[i][14]);
                        u.Acceso = Escape.getString(dt.Rows[i][15]);

                        us.Add(u);
                    }
                }
            }
            catch
            {
                if (da != null)
                {
                    da.Dispose();
                }
                throw;
            }
            return us.ToArray<Usuario>();
        }
    }

    public static Usuario[] Altas
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Usuario> us = new List<Usuario>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_USER.ID_USER, VN_USER.NEW_USER, VN_USER.REMOVED_USER, VN_USER.TYPE_USER, " +
                               "VN_USER.NAME_USER, VN_USER.SURNAMES_USER, VN_USER.EMAIL_USER, " +
                               "VN_USER.LOGIN, VN_USER.PASSWORD, VN_USER.NOTES_USER, VN_USER.DATE_REMOVED, VN_USER.DATE_USER_MOD, " +
                               "VN_USER.ID_USER_MOD, VN_USER.ID_FAMILY, VN_USER.AREA, VN_USER.VN_ACCESS " +
                               "FROM VN_USER " +
                                "WHERE (VN_USER.DATE_REMOVED IS NULL OR VN_USER.DATE_REMOVED = '') " +
                                "ORDER BY VN_USER.AREA DESC, VN_USER.SURNAMES_USER, VN_USER.NAME_USER, VN_USER.LOGIN";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Usuario u = new Usuario();
                        u.Id = Escape.getInt(dt.Rows[i][0]);
                        u.Alta = Escape.getString(dt.Rows[i][1]);
                        u.Baja = Escape.getString(dt.Rows[i][2]);
                        u.Tipo = Escape.getString(dt.Rows[i][3]);
                        u.Nombre = Escape.getString(dt.Rows[i][4]);
                        u.Apellidos = Escape.getString(dt.Rows[i][5]);
                        u.Email = Escape.getString(dt.Rows[i][6]);
                        u.Login = Escape.getString(dt.Rows[i][7]);
                        u.Clave = Escape.getString(dt.Rows[i][8]);
                        u.Notas = Escape.getString(dt.Rows[i][9]);
                        u.Fec_baja = Escape.getString(dt.Rows[i][10]);
                        u.Fec_mod = Escape.getString(dt.Rows[i][11]);
                        u.Id_mod = Escape.getInt(dt.Rows[i][12]);
                        int idfamilia = -1;
                        if (int.TryParse(Escape.getString(dt.Rows[i][13]), out idfamilia) != false)
                        {
                            u.Familia = Familia.getById(idfamilia);
                        }
                        else
                        {
                            u.Familia = null;
                        }
                        u.Area = Escape.getString(dt.Rows[i][14]);
                        u.Acceso = Escape.getString(dt.Rows[i][15]);

                        us.Add(u);
                    }
                }
            }
            catch
            {
                if (da != null)
                {
                    da.Dispose();
                }
                throw;
            }
            return us.ToArray<Usuario>();
        }
    }

    public void Insertar()
    {
        OdbcCommand c = null;
        OdbcTransaction t = null;

        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        try
        {
            if (this.Login.Length < 1)
            {
                throw new Exception("Nombre de usuario no válido");
            }
            if (this.Clave.Length < 1)
            {
                throw new Exception("Contraseña de usuario no válida");
            }
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return;
                }

                // chequea si ya se ha usado ese nombre de usuario
                query = "SELECT VN_USER.LOGIN FROM VN_USER WHERE VN_USER.LOGIN = '" + Escape.MySql(this.Login) + "'";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                if (dt.Rows.Count > 0)
                {
                    throw new Exception("El usuario ha sido dado de alta previamente");
                }

                //obtiene el siguiente identificador para los datos del usuario
                query = "SELECT MAX(VN_USER.ID_USER) AS \"CERO\" FROM VN_USER";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                int idusuario = 1;
                if (dt.Rows.Count > 0)
                {
                    idusuario = (Escape.getInt(dt.Rows[0][0]) < 0) ? 1 : Escape.getInt(dt.Rows[0][0]) + 1;
                }


                // comienza la transacción
                t = Common.ActiveConnection.Connection.BeginTransaction();
                c = new OdbcCommand();
                c.Connection = Common.ActiveConnection.Connection;
                c.Transaction = t;

                c.CommandText = "INSERT INTO VN_USER (ID_USER, NEW_USER, REMOVED_USER, TYPE_USER, NAME_USER, SURNAMES_USER, " +
                                    "EMAIL_USER, LOGIN, PASSWORD, NOTES_USER, DATE_REMOVED, DATE_USER_MOD, " +
                                    "ID_USER_MOD, ID_FAMILY, AREA, VN_ACCESS) " +
                                    "VALUES (" + idusuario + ", '" + Escape.MySql(this.Alta) + "', '" + Escape.MySql(this.Baja) + "', '" + Escape.MySql(this.Tipo) + "', " +
                                    "'" + Escape.MySql(this.Nombre) + "', '" + Escape.MySql(this.Apellidos) + "', '" + Escape.MySql(this.Email) + "', " +
                                    "'" + Escape.MySql(this.Login) + "', '" + Escape.MySql(this.Clave) + "', " +
                                    "'" + Escape.MySql(this.Notas) + "', ";
                if (this.Fec_baja != null)
                {
                    c.CommandText += "'" + Escape.MySql(this.Fec_baja) + "', ";
                }
                else
                {
                    c.CommandText += "NULL, ";
                }
                c.CommandText += "'" + Escape.MySql(this.Fec_mod) + "', " +
                                    this.Id_mod + ", ";
                if (this.Familia != null)
                {
                    c.CommandText += "'" + Escape.MySql(this.Familia.Id.ToString()) + "', ";
                }
                else
                {
                    c.CommandText += "NULL, ";
                }
                c.CommandText += "'" + Escape.MySql(this.Area) + "', 'DESHABILITADO')";

                c.ExecuteNonQuery();
                t.Commit();
                t = null;

                this.Id = idusuario;

                if (c != null)
                {
                    c.Dispose();
                }
            }
        }
        catch
        {
            if (t != null)
            {
                t.Rollback();
                t.Dispose();
            }
            t = null;
            if (c != null)
            {
                c.Dispose();
            }
            if (da != null)
            {
                da.Dispose();
            }
            throw;
        }
    }

    public void Eliminar()
    {
        OdbcCommand c = null;
        OdbcTransaction t = null;

        string query = string.Empty;

        try
        {
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return;
                }

                // comienza la transacción
                t = Common.ActiveConnection.Connection.BeginTransaction();
                c = new OdbcCommand();
                c.Connection = Common.ActiveConnection.Connection;
                c.Transaction = t;

                // borra el usuario
                c.CommandText = "DELETE FROM VN_USER WHERE VN_USER.ID_USER = " + this.Id;
                c.ExecuteNonQuery();

                t.Commit();
                t = null;

                if (c != null)
                {
                    c.Dispose();
                }
            }
        }
        catch
        {
            if (t != null)
            {
                t.Rollback();
                t.Dispose();
            }
            t = null;
            if (c != null)
            {
                c.Dispose();
            }
            throw;
        }
    }

    public static Usuario getById(int id)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Usuario u = null;

        try
        {
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return null;
                }
            }

            // comprueba que existe el usuario
            query = "SELECT VN_USER.ID_USER, VN_USER.NEW_USER, VN_USER.REMOVED_USER, VN_USER.TYPE_USER, " +
                               "VN_USER.NAME_USER, VN_USER.SURNAMES_USER, VN_USER.EMAIL_USER, " +
                               "VN_USER.LOGIN, VN_USER.PASSWORD, VN_USER.NOTES_USER, VN_USER.DATE_REMOVED, VN_USER.DATE_USER_MOD, " +
                               "VN_USER.ID_USER_MOD, VN_USER.ID_FAMILY, VN_USER.AREA, VN_USER.VN_ACCESS " +
                               "FROM VN_USER " +
                        "WHERE VN_USER.ID_USER = " + id + " " +
                        "ORDER BY VN_USER.AREA DESC, VN_USER.SURNAMES_USER, VN_USER.NAME_USER, VN_USER.LOGIN";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                u = new Usuario();
                u.Id = Escape.getInt(dt.Rows[0][0]);
                u.Alta = Escape.getString(dt.Rows[0][1]);
                u.Baja = Escape.getString(dt.Rows[0][2]);
                u.Tipo = Escape.getString(dt.Rows[0][3]);
                u.Nombre = Escape.getString(dt.Rows[0][4]);
                u.Apellidos = Escape.getString(dt.Rows[0][5]);
                u.Email = Escape.getString(dt.Rows[0][6]);
                u.Login = Escape.getString(dt.Rows[0][7]);
                u.Clave = Escape.getString(dt.Rows[0][8]);
                u.Notas = Escape.getString(dt.Rows[0][9]);
                u.Fec_baja = Escape.getString(dt.Rows[0][10]);
                u.Fec_mod = Escape.getString(dt.Rows[0][11]);
                u.Id_mod = Escape.getInt(dt.Rows[0][12]);
                int idfamilia = -1;
                if (int.TryParse(Escape.getString(dt.Rows[0][13]), out idfamilia) != false)
                {
                    u.Familia = Familia.getById(idfamilia);
                }
                else
                {
                    u.Familia = null;
                }
                u.Area = Escape.getString(dt.Rows[0][14]);
                u.Acceso = Escape.getString(dt.Rows[0][15]);
            }
        }
        catch
        {
            if (da != null)
            {
                da.Dispose();
            }
            throw;
        }
        return u;
    }

    public static Usuario getByLogin(string l)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Usuario u = null;

        try
        {
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return null;
                }
            }

            // comprueba que existe el usuario
            query = "SELECT VN_USER.ID_USER, VN_USER.NEW_USER, VN_USER.REMOVED_USER, VN_USER.TYPE_USER, " +
                               "VN_USER.NAME_USER, VN_USER.SURNAMES_USER, VN_USER.EMAIL_USER, " +
                               "VN_USER.LOGIN, VN_USER.PASSWORD, VN_USER.NOTES_USER, VN_USER.DATE_REMOVED, VN_USER.DATE_USER_MOD, " +
                               "VN_USER.ID_USER_MOD, VN_USER.ID_FAMILY, VN_USER.AREA, VN_USER.VN_ACCESS " +
                               "FROM VN_USER " +
                        "WHERE VN_USER.LOGIN = '" + Escape.MySql(l) + "' " +
                        "ORDER BY VN_USER.AREA DESC, VN_USER.SURNAMES_USER, VN_USER.NAME_USER, VN_USER.LOGIN";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                u = new Usuario();
                u.Id = Escape.getInt(dt.Rows[0][0]);
                u.Alta = Escape.getString(dt.Rows[0][1]);
                u.Baja = Escape.getString(dt.Rows[0][2]);
                u.Tipo = Escape.getString(dt.Rows[0][3]);
                u.Nombre = Escape.getString(dt.Rows[0][4]);
                u.Apellidos = Escape.getString(dt.Rows[0][5]);
                u.Email = Escape.getString(dt.Rows[0][6]);
                u.Login = Escape.getString(dt.Rows[0][7]);
                u.Clave = Escape.getString(dt.Rows[0][8]);
                u.Notas = Escape.getString(dt.Rows[0][9]);
                u.Fec_baja = Escape.getString(dt.Rows[0][10]);
                u.Fec_mod = Escape.getString(dt.Rows[0][11]);
                u.Id_mod = Escape.getInt(dt.Rows[0][12]);
                int idfamilia = -1;
                if (int.TryParse(Escape.getString(dt.Rows[0][13]), out idfamilia) != false)
                {
                    u.Familia = Familia.getById(idfamilia);
                }
                else
                {
                    u.Familia = null;
                }
                u.Area = Escape.getString(dt.Rows[0][14]);
                u.Acceso = Escape.getString(dt.Rows[0][15]);
            }
        }
        catch
        {
            if (da != null)
            {
                da.Dispose();
            }
            throw;
        }
        return u;
    }
    
    public static Usuario[] getByFamilia(int idfamilia)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        List<Usuario> us = new List<Usuario>();

        try
        {
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return null;
                }

                // comprueba que existe el usuario
                query = "SELECT VN_USER.ID_USER, VN_USER.NEW_USER, VN_USER.REMOVED_USER, VN_USER.TYPE_USER, " +
                                   "VN_USER.NAME_USER, VN_USER.SURNAMES_USER, VN_USER.EMAIL_USER, " +
                                   "VN_USER.LOGIN, VN_USER.PASSWORD, VN_USER.NOTES_USER, VN_USER.DATE_REMOVED, VN_USER.DATE_USER_MOD, " +
                                   "VN_USER.ID_USER_MOD, VN_USER.ID_FAMILY, VN_USER.AREA, VN_USER.VN_ACCESS " +
                                   "FROM VN_USER " +
                            "WHERE VN_USER.ID_EMPRESA = " + idfamilia + " " +
                            "ORDER BY VN_USER.AREA DESC, VN_USER.SURNAMES_USER, VN_USER.NAME_USER, VN_USER.LOGIN";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Usuario u = new Usuario();
                    u.Id = Escape.getInt(dt.Rows[i][0]);
                    u.Alta = Escape.getString(dt.Rows[i][1]);
                    u.Baja = Escape.getString(dt.Rows[i][2]);
                    u.Tipo = Escape.getString(dt.Rows[i][3]);
                    u.Nombre = Escape.getString(dt.Rows[i][4]);
                    u.Apellidos = Escape.getString(dt.Rows[i][5]);
                    u.Email = Escape.getString(dt.Rows[i][6]);
                    u.Login = Escape.getString(dt.Rows[i][7]);
                    u.Clave = Escape.getString(dt.Rows[i][8]);
                    u.Notas = Escape.getString(dt.Rows[i][9]);
                    u.Fec_baja = Escape.getString(dt.Rows[i][10]);
                    u.Fec_mod = Escape.getString(dt.Rows[i][11]);
                    u.Id_mod = Escape.getInt(dt.Rows[i][12]);
                    int idfam = -1;
                    if (int.TryParse(Escape.getString(dt.Rows[i][13]), out idfam) != false)
                    {
                        u.Familia = Familia.getById(idfam);
                    }
                    else
                    {
                        u.Familia = null;
                    }
                    u.Area = Escape.getString(dt.Rows[i][14]);
                    u.Acceso = Escape.getString(dt.Rows[i][15]);

                    us.Add(u);
                }
            }
        }
        catch
        {
            if (da != null)
            {
                da.Dispose();
            }
            throw;
        }
        return us.ToArray<Usuario>();
    }

    public void Actualizar()
    {
        OdbcCommand c = null;
        OdbcTransaction t = null;

        try
        {
            if (this.Login.Length < 1)
            {
                throw new Exception("Nombre de usuario no válido");
            }
            if (this.Clave.Length < 1)
            {
                throw new Exception("Contraseña de usuario no válida");
            }

            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return;
                }
                
                // comienza la transacción
                t = Common.ActiveConnection.Connection.BeginTransaction();
                c = new OdbcCommand();
                c.Connection = Common.ActiveConnection.Connection;
                c.Transaction = t;

                c.CommandText = "UPDATE VN_USER " +
                                    "SET NEW_USER = '" + Escape.MySql(this.Alta) + "', " +
                                    "REMOVED_USER = '" + Escape.MySql(this.Baja) + "', " +
                                    "TYPE_USER = '" + Escape.MySql(this.Tipo) + "', " +
                                    "NAME_USER = '" + Escape.MySql(this.Nombre) + "', " +
                                    "SURNAMES_USER = '" + Escape.MySql(this.Apellidos) + "', " +
                                    "EMAIL_USER = '" + Escape.MySql(this.Email) + "', " +
                                    "LOGIN = '" + Escape.MySql(this.Login) + "', " +
                                    "PASSWORD = '" + Escape.MySql(this.Clave) + "', " +
                                    "NOTES_USER = '" + Escape.MySql(this.Notas) + "', ";
                if (this.Fec_baja != null)
                {
                    c.CommandText += "DATE_REMOVED = '" + Escape.MySql(this.Fec_baja) + "', ";
                }
                else
                {
                    c.CommandText += "DATE_REMOVED = NULL, ";
                }
                c.CommandText += "DATE_USER_MOD = '" + Escape.MySql(this.Fec_mod) + "', " +
                                    "ID_USER_MOD = " + this.Id_mod + ", ";
                if (this.Familia != null)
                {
                    c.CommandText += "ID_FAMILY = '" + Escape.MySql(this.Familia.Id.ToString()) + "', ";
                }
                else
                {
                    c.CommandText += "ID_FAMILY = NULL, ";
                }
                c.CommandText += "AREA = '" + Escape.MySql(this.Area) + "', " +
                                    "VN_ACCESS = '" + Escape.MySql(this.Acceso) + "' ";
                c.CommandText += "WHERE VN_USER.ID_USER = " + this.Id;
                c.ExecuteNonQuery();

                t.Commit();
                t = null;

                if (c != null)
                {
                    c.Dispose();
                }
            }
        }
        catch
        {
            if (t != null)
            {
                t.Rollback();
                t.Dispose();
            }
            t = null;
            if (c != null)
            {
                c.Dispose();
            }
            throw;
        }
    }

    public static int Count
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;

            int cnt = -1;
            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return -1;
                    }

                    query = "SELECT COUNT(VN_USER.ID_USER) " +
                            "FROM VN_USER";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();

                    if (dt.Rows.Count > 0)
                    {
                        cnt = Escape.getInt(dt.Rows[0][0]);
                    }
                }
            }
            catch
            {
                if (da != null)
                {
                    da.Dispose();
                }
                throw;
            }
            return cnt;
        }
    }

    #region "IEquatable(Of Usuario) Members"
    public bool Equals(Usuario other)
    {
        if (!Escape.IsNull(this) && !Escape.IsNull(other))
        {
            return this.Id == other.Id;
        }
        else
        {
            if (Escape.IsNull(this) && Escape.IsNull(other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public override bool Equals(object obj)
    {
        if ((obj == null))
        {
            return base.Equals(obj);
        }
        if ((obj is Usuario))
        {
            return Equals((Usuario)obj);
        }
        else
        {
            return false;
        }

    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public static bool operator ==(Usuario u1, Usuario u2)
    {
        if (!Escape.IsNull(u1))
        {
            return u1.Equals(u2);
        }
        else
        {
            if (Escape.IsNull(u1) && Escape.IsNull(u2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static bool operator !=(Usuario u1, Usuario u2)
    {
        if (!Escape.IsNull(u1))
        {
            return !u1.Equals(u2);
        }
        else
        {
            if (Escape.IsNull(u1) && Escape.IsNull(u2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    #endregion

    #region "IComparable(Of Usuario) Members"
    public int CompareTo(Usuario other)
    {
        if (!Escape.IsNull(this) && !Escape.IsNull(other))
        {
            return this.Id.CompareTo(other.Id);
        }
        else
        {
            if (Escape.IsNull(this) && Escape.IsNull(other))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
    #endregion

    public Usuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
