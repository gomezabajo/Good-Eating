using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Summary description for Familia
/// </summary>
public class Familia
{
    public int Id;
    public string Alta;
    public string Baja;
    public string Tipo;
    public string Nombre;
    public string Clave;
    public string Email;
    public string Notas;
    public string Fec_baja;
    public string Fec_mod;
    public int Id_mod;

    public static Familia[] Familias
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Familia> fam = new List<Familia>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_FAMILY.ID_FAMILY, VN_FAMILY.NEW_FAMILY, VN_FAMILY.REMOVED_FAMILY, VN_FAMILY.TYPE_FAMILY, " +
                                "VN_FAMILY.NAME_FAMILY, VN_FAMILY.PASSWORD_FAMILY, VN_FAMILY.EMAIL_FAMILY, VN_FAMILY.NOTES_FAMILY, VN_FAMILY.DATE_REMOVED, VN_FAMILY.DATE_FAMILY_MOD, " +
                                "VN_FAMILY.ID_FAMILY_MOD " +
                                "FROM VN_FAMILY " +
                                "ORDER BY VN_FAMILY.NAME_FAMILY";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Familia f = new Familia();
                        f.Id = Escape.getInt(dt.Rows[i][0]);
                        f.Alta = Escape.getString(dt.Rows[i][1]);
                        f.Baja = Escape.getString(dt.Rows[i][2]);
                        f.Tipo = Escape.getString(dt.Rows[i][3]);
                        f.Nombre = Escape.getString(dt.Rows[i][4]);
                        f.Clave = Escape.getString(dt.Rows[i][5]);
                        f.Email = Escape.getString(dt.Rows[i][6]);
                        f.Notas = Escape.getString(dt.Rows[i][7]);
                        f.Fec_baja = Escape.getString(dt.Rows[i][8]);
                        f.Fec_mod = Escape.getString(dt.Rows[i][9]);
                        f.Id_mod = Escape.getInt(dt.Rows[i][10]);

                        fam.Add(f);
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
            return fam.ToArray<Familia>();
        }
    }

    public static Familia[] Bajas
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Familia> fam = new List<Familia>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_FAMILY.ID_FAMILY, VN_FAMILY.NEW_FAMILY, VN_FAMILY.REMOVED_FAMILY, VN_FAMILY.TYPE_FAMILY, " +
                                "VN_FAMILY.NAME_FAMILY, VN_FAMILY.PASSWORD_FAMILY, VN_FAMILY.EMAIL_FAMILY, VN_FAMILY.NOTES_FAMILY, VN_FAMILY.DATE_REMOVED, VN_FAMILY.DATE_FAMILY_MOD, " +
                                "VN_FAMILY.ID_FAMILY_MOD " +
                               "FROM VN_FAMILY " +
                                "WHERE (VN_FAMILY.DATE_REMOVED IS NOT NULL AND NOT VN_FAMILY.DATE_REMOVED = '') " +
                                "ORDER BY VN_FAMILY.NAME_FAMILY";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Familia f = new Familia();
                        f.Id = Escape.getInt(dt.Rows[i][0]);
                        f.Alta = Escape.getString(dt.Rows[i][1]);
                        f.Baja = Escape.getString(dt.Rows[i][2]);
                        f.Tipo = Escape.getString(dt.Rows[i][3]);
                        f.Nombre = Escape.getString(dt.Rows[i][4]);
                        f.Clave = Escape.getString(dt.Rows[i][5]);
                        f.Email = Escape.getString(dt.Rows[i][6]);
                        f.Notas = Escape.getString(dt.Rows[i][7]);
                        f.Fec_baja = Escape.getString(dt.Rows[i][8]);
                        f.Fec_mod = Escape.getString(dt.Rows[i][9]);
                        f.Id_mod = Escape.getInt(dt.Rows[i][10]);

                        fam.Add(f);

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
            return fam.ToArray<Familia>();
        }
    }

    public static Familia[] Altas
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Familia> fam = new List<Familia>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_FAMILY.ID_FAMILY, VN_FAMILY.NEW_FAMILY, VN_FAMILY.REMOVED_FAMILY, VN_FAMILY.TYPE_FAMILY, " +
                               "VN_FAMILY.NAME_FAMILY, VN_FAMILY.PASSWORD_FAMILY, VN_FAMILY.EMAIL_FAMILY, VN_FAMILY.NOTES_FAMILY, VN_FAMILY.DATE_REMOVED, VN_FAMILY.DATE_FAMILY_MOD, " +
                               "VN_FAMILY.ID_FAMILY_MOD " +
                               "FROM VN_FAMILY " +
                                "WHERE (VN_FAMILY.DATE_REMOVED IS NULL OR VN_FAMILY.DATE_REMOVED = '') " +
                                "ORDER BY VN_FAMILY.NAME_FAMILY";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Familia f = new Familia();
                        f.Id = Escape.getInt(dt.Rows[i][0]);
                        f.Alta = Escape.getString(dt.Rows[i][1]);
                        f.Baja = Escape.getString(dt.Rows[i][2]);
                        f.Tipo = Escape.getString(dt.Rows[i][3]);
                        f.Nombre = Escape.getString(dt.Rows[i][4]);
                        f.Clave = Escape.getString(dt.Rows[i][5]);
                        f.Email = Escape.getString(dt.Rows[i][6]);
                        f.Notas = Escape.getString(dt.Rows[i][7]);
                        f.Fec_baja = Escape.getString(dt.Rows[i][8]);
                        f.Fec_mod = Escape.getString(dt.Rows[i][9]);
                        f.Id_mod = Escape.getInt(dt.Rows[i][10]);

                        fam.Add(f);
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
            return fam.ToArray<Familia>();
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
            if (this.Nombre.Length < 1)
            {
                throw new Exception("Nombre de familia no válido");
            }
            if (this.Clave.Length < 1)
            {
                throw new Exception("Contraseña de familia no válida");
            }
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return;
                }

                // chequea si ya se ha usado ese nombre de usuario
                query = "SELECT VN_FAMILY.NAME_FAMILY FROM VN_FAMILY WHERE VN_FAMILY.NAME_FAMILY = '" + Escape.MySql(this.Nombre) + "'";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                if (dt.Rows.Count > 0)
                {
                    throw new Exception("La familia ya ha sido dada de alta");
                }

                //obtiene el siguiente identificador para los datos del usuario
                query = "SELECT MAX(VN_FAMILY.ID_FAMILY) AS \"CERO\" FROM VN_FAMILY";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                int idfamilia = 1;
                if (dt.Rows.Count > 0)
                {
                    idfamilia = (Escape.getInt(dt.Rows[0][0]) < 0) ? 1 : Escape.getInt(dt.Rows[0][0]) + 1;
                }


                // comienza la transacción
                t = Common.ActiveConnection.Connection.BeginTransaction();
                c = new OdbcCommand();
                c.Connection = Common.ActiveConnection.Connection;
                c.Transaction = t;

                c.CommandText = "INSERT INTO VN_FAMILY (ID_FAMILY, NEW_FAMILY, REMOVED_FAMILY, TYPE_FAMILY, NAME_FAMILY, PASSWORD_FAMILY, " +
                                    "EMAIL_FAMILY, NOTES_FAMILY, DATE_REMOVED, DATE_FAMILY_MOD, ID_FAMILY_MOD) " +
                                    "VALUES (" + idfamilia + ", '" + Escape.MySql(this.Alta) + "', '" + Escape.MySql(this.Baja) + "', '" + Escape.MySql(this.Tipo) + "', " +
                                    "'" + Escape.MySql(this.Nombre) + "', '" + Escape.MySql(this.Clave) + "', " +
                                    "'" + Escape.MySql(this.Email) + "', '" + Escape.MySql(this.Notas) + "', ";
                if (this.Fec_baja != null)
                {
                    c.CommandText += "'" + Escape.MySql(this.Fec_baja) + "', ";
                }
                else
                {
                    c.CommandText += "NULL, ";
                }
                c.CommandText += "'" + Escape.MySql(this.Fec_mod) + "', " +
                                    this.Id_mod + ")";

                c.ExecuteNonQuery();
                t.Commit();
                t = null;

                this.Id = idfamilia;

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

                // borra los usuarios
                c.CommandText = "DELETE FROM VN_USER WHERE VN_USER.ID_FAMILY = " + this.Id;
                c.ExecuteNonQuery();

                // borra la familia
                c.CommandText = "DELETE FROM VN_FAMILY WHERE VN_FAMILY.ID_FAMILY = " + this.Id;
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

    public static Familia getById(int id)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Familia f = null;

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
            query = "SELECT VN_FAMILY.ID_FAMILY, VN_FAMILY.NEW_FAMILY, VN_FAMILY.REMOVED_FAMILY, VN_FAMILY.TYPE_FAMILY, " +
                                "VN_FAMILY.NAME_FAMILY, VN_FAMILY.PASSWORD_FAMILY, VN_FAMILY.EMAIL_FAMILY, VN_FAMILY.NOTES_FAMILY, VN_FAMILY.DATE_REMOVED, VN_FAMILY.DATE_FAMILY_MOD, " +
                                "VN_FAMILY.ID_FAMILY_MOD " +
                                "FROM VN_FAMILY " +
                        "WHERE VN_FAMILY.ID_FAMILY = " + id + " " +
                        "ORDER BY VN_FAMILY.NAME_FAMILY";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                f = new Familia();
                f.Id = Escape.getInt(dt.Rows[0][0]);
                f.Alta = Escape.getString(dt.Rows[0][1]);
                f.Baja = Escape.getString(dt.Rows[0][2]);
                f.Tipo = Escape.getString(dt.Rows[0][3]);
                f.Nombre = Escape.getString(dt.Rows[0][4]);
                f.Clave = Escape.getString(dt.Rows[0][5]);
                f.Email = Escape.getString(dt.Rows[0][6]);
                f.Notas = Escape.getString(dt.Rows[0][7]);
                f.Fec_baja = Escape.getString(dt.Rows[0][8]);
                f.Fec_mod = Escape.getString(dt.Rows[0][9]);
                f.Id_mod = Escape.getInt(dt.Rows[0][10]);
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
        return f;
    }

    public static Familia getByNombre(string nombre)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Familia f = null;

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
            query = "SELECT VN_FAMILY.ID_FAMILY, VN_FAMILY.NEW_FAMILY, VN_FAMILY.REMOVED_FAMILY, VN_FAMILY.TYPE_FAMILY, " +
                                "VN_FAMILY.NAME_FAMILY, VN_FAMILY.PASSWORD_FAMILY, VN_FAMILY.EMAIL_FAMILY, VN_FAMILY.NOTES_FAMILY, VN_FAMILY.DATE_REMOVED, VN_FAMILY.DATE_FAMILY_MOD, " +
                                "VN_FAMILY.ID_FAMILY_MOD " +
                                "FROM VN_FAMILY " +
                        "WHERE VN_FAMILY.NAME_FAMILY = '" + Escape.MySql(nombre) + "' " +
                        "ORDER BY VN_FAMILY.NAME_FAMILY";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                f = new Familia();
                f.Id = Escape.getInt(dt.Rows[0][0]);
                f.Alta = Escape.getString(dt.Rows[0][1]);
                f.Baja = Escape.getString(dt.Rows[0][2]);
                f.Tipo = Escape.getString(dt.Rows[0][3]);
                f.Nombre = Escape.getString(dt.Rows[0][4]);
                f.Clave = Escape.getString(dt.Rows[0][5]);
                f.Email = Escape.getString(dt.Rows[0][6]);
                f.Notas = Escape.getString(dt.Rows[0][7]);
                f.Fec_baja = Escape.getString(dt.Rows[0][8]);
                f.Fec_mod = Escape.getString(dt.Rows[0][9]);
                f.Id_mod = Escape.getInt(dt.Rows[0][10]);
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
        return f;
    }


    public void Actualizar()
    {
        OdbcCommand c = null;
        OdbcTransaction t = null;

        try
        {
            if (this.Nombre.Length < 1)
            {
                throw new Exception("Nombre de familia no válida");
            }
            if (this.Clave.Length < 1)
            {
                throw new Exception("Contraseña de familia no válida");
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

                c.CommandText = "UPDATE VN_FAMILY " +
                                    "SET NEW_FAMILY = '" + Escape.MySql(this.Alta) + "', " +
                                    "REMOVED_FAMILY = '" + Escape.MySql(this.Baja) + "', " +
                                    "TYPE_FAMILY = '" + Escape.MySql(this.Tipo) + "', " +
                                    "NAME_FAMILY = '" + Escape.MySql(this.Nombre) + "', " +
                                    "PASSWORD_FAMILY = '" + Escape.MySql(this.Clave) + "', " +
                                    "EMAIL_FAMILY = '" + Escape.MySql(this.Email) + "', " +
                                    "NOTES_FAMILY = '" + Escape.MySql(this.Notas) + "', ";
                if (this.Fec_baja != null)
                {
                    c.CommandText += "DATE_REMOVED = '" + Escape.MySql(this.Fec_baja) + "', ";
                }
                else
                {
                    c.CommandText += "DATE_REMOVED = NULL, ";
                }
                c.CommandText += "DATE_FAMILY_MOD = '" + Escape.MySql(this.Fec_mod) + "', " +
                                    "ID_FAMILY_MOD = " + this.Id_mod + " ";
                c.CommandText += "WHERE VN_FAMILY.ID_FAMILY = " + this.Id;
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

                    query = "SELECT COUNT(VN_FAMILY.ID_FAMILY) " +
                            "FROM VN_FAMILY";
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

    #region "IEquatable(Of Familia) Members"
    public bool Equals(Familia other)
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
        if ((obj is Familia))
        {
            return Equals((Familia)obj);
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

    public static bool operator ==(Familia u1, Familia u2)
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

    public static bool operator !=(Familia u1, Familia u2)
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

    #region "IComparable(Of Familia) Members"
    public int CompareTo(Familia other)
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

    public Familia()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
