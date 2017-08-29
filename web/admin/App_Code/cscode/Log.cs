using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Descripción breve de Log
/// </summary>
public class Log : IEquatable<Log>, IComparable<Log>
{
    public int Id;
    public Usuario Usuario;
    public string Operacion;
    public string Fecha;

    public static Log[] Logs
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Log> ls = new List<Log>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_LOG.ID_LOG, VN_LOG.LOGIN, VN_LOG.OP, VN_LOG.DATED " +
                                "FROM VN_LOG " +
                                "ORDER BY VN_LOG.ID_LOG DESC";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Log l = new Log();
                        l.Id = Escape.getInt(dt.Rows[i][0]);
                        l.Usuario = Usuario.getByLogin(Escape.getString(dt.Rows[i][1]));
                        l.Operacion = Escape.getString(dt.Rows[i][2]);
                        l.Fecha = Escape.getString(dt.Rows[i][3]);

                        ls.Add(l);
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
            return ls.ToArray<Log>();
        }
    }

    public static Log[] getByArea(string[] area)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;

        string query = string.Empty;
        List<Log> ls = new List<Log>();

        try
        {
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return null;
                }

                query = "SELECT VN_LOG.ID_LOG, VN_LOG.LOGIN, VN_LOG.OP, VN_LOG.DATED " +
                        "FROM VN_LOG, VN_USER " +
                        "WHERE VN_LOG.LOGIN = VN_USER.LOGIN ";
                if (area != null)
                {
                    if (area.Length > 0)
                    {
                        query += "AND (0 ";
                        for (int i = 0; i < area.Length; i++)
                        {
                            query += "OR VN_USER.AREA = '" + area[i] + "' ";
                        }
                        query += ") ";
                    }
                }
                query += "ORDER BY VN_LOG.ID_LOG DESC LIMIT 500";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Log l = new Log();
                    l.Id = Escape.getInt(dt.Rows[i][0]);
                    l.Usuario = Usuario.getByLogin(Escape.getString(dt.Rows[i][1]));
                    l.Operacion = Escape.getString(dt.Rows[i][2]);
                    l.Fecha = Escape.getString(dt.Rows[i][3]);

                    ls.Add(l);
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
        return ls.ToArray<Log>();
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
            if (this.Usuario == null)
            {
                throw new Exception("active user was not initialized");
            }
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return;
                }

                //obtiene el siguiente identificador para los datos del log
                query = "SELECT MAX(VN_LOG.ID_LOG) AS \"CERO\" FROM VN_LOG";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                int idlog = 1;
                if (dt.Rows.Count > 0)
                {
                    idlog = (Escape.getInt(dt.Rows[0][0]) < 0) ? 1 : Escape.getInt(dt.Rows[0][0]) + 1;
                }


                // comienza la transacción
                t = Common.ActiveConnection.Connection.BeginTransaction();
                c = new OdbcCommand();
                c.Connection = Common.ActiveConnection.Connection;
                c.Transaction = t;

                c.CommandText = "INSERT INTO VN_LOG (ID_LOG, LOGIN, OP, DATED) " +
                                    "VALUES (" + idlog + ", '" + Escape.MySql(this.Usuario.Login) + "', '" + Escape.MySql(this.Operacion) + "', ";
                if (this.Fecha != null)
                {
                    c.CommandText += "'" + Escape.MySql(this.Fecha) + "') ";
                }
                else
                {
                    c.CommandText += "NULL)";
                }
                c.ExecuteNonQuery();
                t.Commit();
                t = null;

                if (c != null)
                {
                    c.Dispose();
                }
                this.Id = idlog;
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
                c.CommandText = "DELETE FROM VN_LOG WHERE VN_LOG.ID_LOG = " + this.Id;
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

    public static Log getById(int id)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Log l = null;

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
            query = "SELECT VN_LOG.ID_LOG, VN_LOG.LOGIN, VN_LOG.OP, VN_LOG.DATED " +
                        "FROM VN_LOG " +
                        "WHERE VN_USER.ID_LOG = " + id + " " +
                        "ORDER BY VN_LOG.ID_LOG ASC";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                l = new Log();
                l.Id = Escape.getInt(dt.Rows[0][0]);
                l.Usuario = Usuario.getByLogin(Escape.getString(dt.Rows[0][1]));
                l.Operacion = Escape.getString(dt.Rows[0][2]);
                l.Fecha = Escape.getString(dt.Rows[0][3]);
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
        return l;
    }

    public static Log getByLogin(string user)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Log l = null;

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
            query = "SELECT VN_LOG.ID_LOG, VN_LOG.LOGIN, VN_LOG.OP, VN_LOG.DATED " +
                        "FROM VN_LOG " +
                        "WHERE VN_USER.LOGIN '" + Escape.MySql(user) + "' " +
                        "ORDER BY VN_LOG.ID_LOG ASC";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                l = new Log();
                l.Id = Escape.getInt(dt.Rows[0][0]);
                l.Usuario = Usuario.getByLogin(Escape.getString(dt.Rows[0][1]));
                l.Operacion = Escape.getString(dt.Rows[0][2]);
                l.Fecha = Escape.getString(dt.Rows[0][3]);
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
        return l;
    }

    public void Actualizar()
    {
        OdbcCommand c = null;
        OdbcTransaction t = null;

        try
        {
            if (this.Usuario == null)
            {
                throw new Exception("active user was not initialized");
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

                c.CommandText = "UPDATE VN_LOG " +
                                    "SET LOGIN = '" + Escape.MySql(this.Usuario.Login) + "', " +
                                    "OP = '" + Escape.MySql(this.Operacion) + "', ";
                if (this.Fecha != null)
                {
                    c.CommandText += "DATED = '" + Escape.MySql(this.Fecha) + "' ";
                }
                else
                {
                    c.CommandText += "DATED = NULL ";
                }
                c.CommandText += "WHERE VN_LOG.ID_LOG = " + this.Id;
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

                    query = "SELECT COUNT(VN_LOG.ID_LOG) " +
                            "FROM VN_LOG";
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

    #region "IEquatable(Of Log) Members"
    public bool Equals(Log other)
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
        if ((obj is Log))
        {
            return Equals((Log)obj);
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

    public static bool operator ==(Log l1, Log l2)
    {
        if (!Escape.IsNull(l1))
        {
            return l1.Equals(l2);
        }
        else
        {
            if (Escape.IsNull(l1) && Escape.IsNull(l2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static bool operator !=(Log l1, Log l2)
    {
        if (!Escape.IsNull(l1))
        {
            return !l1.Equals(l2);
        }
        else
        {
            if (Escape.IsNull(l1) && Escape.IsNull(l2))
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

    #region "IComparable(Of Log) Members"
    public int CompareTo(Log other)
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

    public Log()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
