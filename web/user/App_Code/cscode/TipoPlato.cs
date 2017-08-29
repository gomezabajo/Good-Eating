using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Descripción breve de TipoPlato
/// </summary>
public class TipoPlato
{
    public int Id;
    public string Nombre;

    public static TipoPlato[] TipoPlatos
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<TipoPlato> tps = new List<TipoPlato>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_TYPE_DISH.ID_TYPE_DISH, VN_TYPE_DISH.NAME " +
                                "FROM VN_TYPE_DISH " +
                                "ORDER BY VN_TYPE_DISH.ID_TYPE_DISH";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        TipoPlato tp = new TipoPlato();
                        tp.Id = Escape.getInt(dt.Rows[i][0]);
                        tp.Nombre = Escape.getString(dt.Rows[i][1]);

                        tps.Add(tp);
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
            return tps.ToArray<TipoPlato>();
        }
    }

    public static TipoPlato getById(int id)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        TipoPlato tp = null;

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

            query = "SELECT VN_TYPE_DISH.ID_TYPE_DISH, VN_TYPE_DISH.NAME " +
                        "FROM VN_TYPE_DISH " +
                        "WHERE VN_TYPE_DISH.ID_TYPE_DISH = " + id + " " +
                        "ORDER BY VN_TYPE_DISH.ID_TYPE_DISH";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tp = new TipoPlato();
                tp.Id = Escape.getInt(dt.Rows[0][0]);
                tp.Nombre = Escape.getString(dt.Rows[0][1]);
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
        return tp;
    }

    public static TipoPlato getByTipo(string tipo)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        TipoPlato tp = null;

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

            query = "SELECT VN_TYPE_DISH.ID_TYPE_DISH, VN_TYPE_DISH.NAME " +
                        "FROM VN_TYPE_DISH " +
                        "WHERE VN_TYPE_DISH.ID_TYPE_DISH = '" + tipo + "' " +
                        "ORDER BY VN_AGES.ID_AGE";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tp = new TipoPlato();
                tp.Id = Escape.getInt(dt.Rows[0][0]);
                tp.Nombre = Escape.getString(dt.Rows[0][1]);
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
        return tp;
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

                    query = "SELECT COUNT(VN_TYPE_DISH.ID_TYPE_DISH) " +
                            "FROM VN_TYPE_DISH";
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

    #region "IEquatable(Of TipoPlato) Members"
    public bool Equals(TipoPlato other)
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
        if ((obj is TipoPlato))
        {
            return Equals((TipoPlato)obj);
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

    public static bool operator ==(TipoPlato u1, TipoPlato u2)
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

    public static bool operator !=(TipoPlato u1, TipoPlato u2)
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

    #region "IComparable(Of TipoPlato) Members"
    public int CompareTo(TipoPlato other)
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

	public TipoPlato()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}
