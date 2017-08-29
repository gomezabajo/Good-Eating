using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Summary description for Pais
/// </summary>
public class Pais
{
    public int Id;
    public string Iso;
    public string Nombre;

    public static Pais[] Paises
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Pais> paises = new List<Pais>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_COUNTRIES.ID_COUNTRY, VN_COUNTRIES.ISO, VN_COUNTRIES.NAME " +
                                "FROM VN_COUNTRIES " +
                                "ORDER BY VN_COUNTRIES.NAME";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Pais p = new Pais();
                        p.Id = Escape.getInt(dt.Rows[i][0]);
                        p.Iso = Escape.getString(dt.Rows[i][1]);
                        p.Nombre = Escape.getString(dt.Rows[i][2]);

                        paises.Add(p);
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
            return paises.ToArray<Pais>();
        }
    }

    public static Pais getById(int id)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Pais p = null;

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

            query = "SELECT VN_COUNTRIES.ID_COUNTRY, VN_COUNTRIES.ISO, VN_COUNTRIES.NAME " +
                        "FROM VN_COUNTRIES " +
                        "WHERE VN_COUNTRIES.ID_COUNTRY = " + id + " " +
                        "ORDER BY VN_COUNTRIES.NAME";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                p = new Pais();
                p.Id = Escape.getInt(dt.Rows[0][0]);
                p.Iso = Escape.getString(dt.Rows[0][1]);
                p.Nombre = Escape.getString(dt.Rows[0][2]);
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
        return p;
    }

    public static Pais getByIso(string iso)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Pais p = null;

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

            query = "SELECT VN_COUNTRIES.ID_COUNTRY, VN_COUNTRIES.ISO, VN_COUNTRIES.NAME " +
                        "FROM VN_COUNTRIES " +
                        "WHERE VN_COUNTRIES.ISO = '" + iso + "' " +
                        "ORDER BY VN_COUNTRIES.NAME";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                p = new Pais();
                p.Id = Escape.getInt(dt.Rows[0][0]);
                p.Iso = Escape.getString(dt.Rows[0][1]);
                p.Nombre = Escape.getString(dt.Rows[0][2]);
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
        return p;
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

                    query = "SELECT COUNT(VN_COUNTRIES.ID_COUNTRY) " +
                            "FROM VN_COUNTRIES";
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

    #region "IEquatable(Of Pais) Members"
    public bool Equals(Pais other)
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
        if ((obj is Pais))
        {
            return Equals((Pais)obj);
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

    public static bool operator ==(Pais u1, Pais u2)
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

    public static bool operator !=(Pais u1, Pais u2)
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

    #region "IComparable(Of Pais) Members"
    public int CompareTo(Pais other)
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

    public Pais()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
