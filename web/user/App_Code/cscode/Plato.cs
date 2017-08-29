using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Descripción breve de Plato
/// </summary>
public class Plato
{
    public int Id;
    public Menu Menu;
    public TipoPlato Tipo_plato;
    public string Nombre;
    public Ingrediente Ingrediente;

    public static Plato[] Platos
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Plato> platos = new List<Plato>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_DISH.ID_DISH, VN_DISH.ID_MENU, VN_DISH.ID_TYPE_DISH, VN_DISH.NAME " +
                                "FROM VN_DISH " +
                                "ORDER BY VN_DISH.ID_DISH";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato p = new Plato();
                        p.Id = Escape.getInt(dt.Rows[i][0]);
                        p.Menu = Menu.getById(Escape.getInt(dt.Rows[i][1]));
                        p.Tipo_plato = TipoPlato.getById(Escape.getInt(dt.Rows[i][2]));
                        p.Nombre = Escape.getString(dt.Rows[i][3]);
                        p.Ingrediente = Ingrediente.getByPlato(p.Id);

                        platos.Add(p);
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
            return platos.ToArray<Plato>();
        }
    }

    public static Plato getById(int id)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Plato p = null;

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

            query = "SELECT VN_DISH.ID_DISH, VN_DISH.ID_MENU, VN_DISH.ID_TYPE_DISH, VN_DISH.NAME " +
                        "FROM VN_DISH " +
                        "WHERE VN_DISH.ID_DISH = " + id + " " +
                        "ORDER BY VN_DISH.ID_DISH";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                p = new Plato();
                p.Id = Escape.getInt(dt.Rows[0][0]);
                p.Menu = Menu.getById(Escape.getInt(dt.Rows[0][1]));
                p.Tipo_plato = TipoPlato.getById(Escape.getInt(dt.Rows[0][2]));
                p.Nombre = Escape.getString(dt.Rows[0][3]);
                p.Ingrediente = Ingrediente.getByPlato(p.Id);
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

                    query = "SELECT COUNT(VN_DISH.ID_DISH) " +
                            "FROM VN_DISH";
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

    #region "IEquatable(Of Plato) Members"
    public bool Equals(Plato other)
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
        if ((obj is Plato))
        {
            return Equals((Plato)obj);
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

    public static bool operator ==(Plato u1, Plato u2)
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

    public static bool operator !=(Plato u1, Plato u2)
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

    #region "IComparable(Of Plato) Members"
    public int CompareTo(Plato other)
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

	public Plato()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}
