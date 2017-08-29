using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;
/// <summary>
/// Descripción breve de Ingrediente
/// </summary>
public class Ingrediente
{
    public Plato Plato;
    public bool Lactosa;
    public bool Fruta;
    public bool Esparrago;
    public bool Espinaca;
    public bool Acelga;
    public bool Cardo;
    public bool Borraja;
    public bool Lechuga;
    public bool Pepinillo;
    public bool Tomate;
    public bool Pimiento;
    public bool Berenjena;
    public bool Calabacin;
    public bool Alcachofa;
    public bool Puerro;
    public bool Ajo;
    public bool Cebolla;
    public bool Nabo;
    public bool Patata;
    public bool Rabanos;
    public bool Remolacha;
    public bool Zanahoria;
    public bool Judias;
    public bool Guisantes;
    public bool Lentejas;
    public bool Alubias;
    public bool Repollo;
    public bool Brecol;
    public bool Coles;
    public bool Coliflor;
    public bool Champinnon;
    public bool Setas;
    public bool Huevos;
    public bool Pan;
    public bool Arroz;
    public bool Pasta;
    public bool Pescado;
    public bool Carne;
    public bool Pollo;

    public static Ingrediente[] Ingredientes
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Ingrediente> ings = new List<Ingrediente>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_INGREDIENT.ID_DISH, VN_INGREDIENT.LACTOSE, VN_INGREDIENT.FRUIT, VN_INGREDIENT.ASPARAGUS, VN_INGREDIENT.SPINACH, VN_INGREDIENT.CHARD, VN_INGREDIENT.THISTLE, " +
                                "VN_INGREDIENT.BORAGE, VN_INGREDIENT.LETTUCE, VN_INGREDIENT.PICKLE, VN_INGREDIENT.TOMATO, VN_INGREDIENT.PEPPER, VN_INGREDIENT.EGGPLANT, VN_INGREDIENT.ZUCCHINI, " +
                                "VN_INGREDIENT.ARTICHOKE, VN_INGREDIENT.LEEK, VN_INGREDIENT.GARLIC, VN_INGREDIENT.ONION, VN_INGREDIENT.TURNIP, VN_INGREDIENT.POTATO, VN_INGREDIENT.RADISHES, " +
                                "VN_INGREDIENT.CARROT, VN_INGREDIENT.GREENBEANS, VN_INGREDIENT.PEAS, VN_INGREDIENT.LENTILS, VN_INGREDIENT.BEANS, VN_INGREDIENT.CABBAGE, VN_INGREDIENT.BRECOL, " +
                                "VN_INGREDIENT.BRUSSELSSPROUTS, VN_INGREDIENT.CAULIFLOWER, VN_INGREDIENT.BEET, VN_INGREDIENT.BUTTONMUSHROOM, VN_INGREDIENT.MUSHROOMS, VN_INGREDIENT.EGGS, VN_INGREDIENT.BREAD, " +
                                "VN_INGREDIENT.RICE, VN_INGREDIENT.PASTA, VN_INGREDIENT.FISH, VN_INGREDIENT.MEAT, VN_INGREDIENT.CHICKEN " +
                                "FROM VN_INGREDIENT " +
                                "ORDER BY VN_INGREDIENT.ID_DISH";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Ingrediente ing = new Ingrediente();
                        ing.Plato = Plato.getById(Escape.getInt(dt.Rows[i][0]));
                        ing.Lactosa = Escape.getBoolean(dt.Rows[i][1]);
                        ing.Fruta = Escape.getBoolean(dt.Rows[i][2]);
                        ing.Esparrago = Escape.getBoolean(dt.Rows[i][3]);
                        ing.Espinaca = Escape.getBoolean(dt.Rows[i][4]);
                        ing.Acelga = Escape.getBoolean(dt.Rows[i][5]);
                        ing.Cardo = Escape.getBoolean(dt.Rows[i][6]);
                        ing.Borraja = Escape.getBoolean(dt.Rows[i][7]);
                        ing.Lechuga = Escape.getBoolean(dt.Rows[i][8]);
                        ing.Pepinillo = Escape.getBoolean(dt.Rows[i][9]);
                        ing.Tomate = Escape.getBoolean(dt.Rows[i][10]);
                        ing.Pimiento = Escape.getBoolean(dt.Rows[i][11]);
                        ing.Berenjena = Escape.getBoolean(dt.Rows[i][12]);
                        ing.Calabacin = Escape.getBoolean(dt.Rows[i][13]);
                        ing.Alcachofa = Escape.getBoolean(dt.Rows[i][14]);
                        ing.Puerro = Escape.getBoolean(dt.Rows[i][15]);
                        ing.Ajo = Escape.getBoolean(dt.Rows[i][16]);
                        ing.Cebolla = Escape.getBoolean(dt.Rows[i][17]);
                        ing.Nabo = Escape.getBoolean(dt.Rows[i][18]);
                        ing.Patata = Escape.getBoolean(dt.Rows[i][19]);
                        ing.Rabanos = Escape.getBoolean(dt.Rows[i][20]);
                        ing.Remolacha = Escape.getBoolean(dt.Rows[i][21]);
                        ing.Zanahoria = Escape.getBoolean(dt.Rows[i][22]);
                        ing.Judias = Escape.getBoolean(dt.Rows[i][23]);
                        ing.Guisantes = Escape.getBoolean(dt.Rows[i][24]);
                        ing.Lentejas = Escape.getBoolean(dt.Rows[i][25]);
                        ing.Alubias = Escape.getBoolean(dt.Rows[i][26]);
                        ing.Repollo = Escape.getBoolean(dt.Rows[i][27]);
                        ing.Brecol = Escape.getBoolean(dt.Rows[i][28]);
                        ing.Coles = Escape.getBoolean(dt.Rows[i][29]);
                        ing.Coliflor = Escape.getBoolean(dt.Rows[i][30]);
                        ing.Champinnon = Escape.getBoolean(dt.Rows[i][31]);
                        ing.Setas = Escape.getBoolean(dt.Rows[i][32]);
                        ing.Huevos = Escape.getBoolean(dt.Rows[i][33]);
                        ing.Pan = Escape.getBoolean(dt.Rows[i][34]);
                        ing.Arroz = Escape.getBoolean(dt.Rows[i][35]);
                        ing.Pasta = Escape.getBoolean(dt.Rows[i][36]);
                        ing.Pescado = Escape.getBoolean(dt.Rows[i][37]);
                        ing.Carne = Escape.getBoolean(dt.Rows[i][38]);
                        ing.Pollo = Escape.getBoolean(dt.Rows[i][39]);

                        ings.Add(ing);
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
            return ings.ToArray<Ingrediente>();
        }
    }

    public static Ingrediente getByPlato(int id_plato)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;

        string query = string.Empty;
        Ingrediente ing = null;

        try
        {
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return null;
                }

                query = "SELECT VN_INGREDIENT.ID_DISH, VN_INGREDIENT.LACTOSE, VN_INGREDIENT.FRUIT, VN_INGREDIENT.ASPARAGUS, VN_INGREDIENT.SPINACH, VN_INGREDIENT.CHARD, VN_INGREDIENT.THISTLE, " +
                            "VN_INGREDIENT.BORAGE, VN_INGREDIENT.LETTUCE, VN_INGREDIENT.PICKLE, VN_INGREDIENT.TOMATO, VN_INGREDIENT.PEPPER, VN_INGREDIENT.EGGPLANT, VN_INGREDIENT.ZUCCHINI, " +
                            "VN_INGREDIENT.ARTICHOKE, VN_INGREDIENT.LEEK, VN_INGREDIENT.GARLIC, VN_INGREDIENT.ONION, VN_INGREDIENT.TURNIP, VN_INGREDIENT.POTATO, VN_INGREDIENT.RADISHES, " +
                            "VN_INGREDIENT.CARROT, VN_INGREDIENT.GREENBEANS, VN_INGREDIENT.PEAS, VN_INGREDIENT.LENTILS, VN_INGREDIENT.BEANS, VN_INGREDIENT.CABBAGE, VN_INGREDIENT.BRECOL, " +
                            "VN_INGREDIENT.BRUSSELSSPROUTS, VN_INGREDIENT.CAULIFLOWER, VN_INGREDIENT.BEET, VN_INGREDIENT.BUTTONMUSHROOM, VN_INGREDIENT.MUSHROOMS, VN_INGREDIENT.EGGS, VN_INGREDIENT.BREAD, " +
                            "VN_INGREDIENT.RICE, VN_INGREDIENT.PASTA, VN_INGREDIENT.FISH, VN_INGREDIENT.MEAT, VN_INGREDIENT.CHICKEN " +
                            "FROM VN_INGREDIENT " +
                            "ORDER BY VN_INGREDIENT.ID_DISH";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ing = new Ingrediente();
                    ing.Plato = Plato.getById(Escape.getInt(dt.Rows[0][0]));
                    ing.Lactosa = Escape.getBoolean(dt.Rows[0][1]);
                    ing.Fruta = Escape.getBoolean(dt.Rows[0][2]);
                    ing.Esparrago = Escape.getBoolean(dt.Rows[0][3]);
                    ing.Espinaca = Escape.getBoolean(dt.Rows[0][4]);
                    ing.Acelga = Escape.getBoolean(dt.Rows[0][5]);
                    ing.Cardo = Escape.getBoolean(dt.Rows[0][6]);
                    ing.Borraja = Escape.getBoolean(dt.Rows[0][7]);
                    ing.Lechuga = Escape.getBoolean(dt.Rows[0][8]);
                    ing.Pepinillo = Escape.getBoolean(dt.Rows[0][9]);
                    ing.Tomate = Escape.getBoolean(dt.Rows[0][10]);
                    ing.Pimiento = Escape.getBoolean(dt.Rows[0][11]);
                    ing.Berenjena = Escape.getBoolean(dt.Rows[0][12]);
                    ing.Calabacin = Escape.getBoolean(dt.Rows[0][13]);
                    ing.Alcachofa = Escape.getBoolean(dt.Rows[0][14]);
                    ing.Puerro = Escape.getBoolean(dt.Rows[0][15]);
                    ing.Ajo = Escape.getBoolean(dt.Rows[0][16]);
                    ing.Cebolla = Escape.getBoolean(dt.Rows[0][17]);
                    ing.Nabo = Escape.getBoolean(dt.Rows[0][18]);
                    ing.Patata = Escape.getBoolean(dt.Rows[0][19]);
                    ing.Rabanos = Escape.getBoolean(dt.Rows[0][20]);
                    ing.Remolacha = Escape.getBoolean(dt.Rows[0][21]);
                    ing.Zanahoria = Escape.getBoolean(dt.Rows[0][22]);
                    ing.Judias = Escape.getBoolean(dt.Rows[0][23]);
                    ing.Guisantes = Escape.getBoolean(dt.Rows[0][24]);
                    ing.Lentejas = Escape.getBoolean(dt.Rows[0][25]);
                    ing.Alubias = Escape.getBoolean(dt.Rows[0][26]);
                    ing.Repollo = Escape.getBoolean(dt.Rows[0][27]);
                    ing.Brecol = Escape.getBoolean(dt.Rows[0][28]);
                    ing.Coles = Escape.getBoolean(dt.Rows[0][29]);
                    ing.Coliflor = Escape.getBoolean(dt.Rows[0][30]);
                    ing.Champinnon = Escape.getBoolean(dt.Rows[0][31]);
                    ing.Setas = Escape.getBoolean(dt.Rows[0][32]);
                    ing.Huevos = Escape.getBoolean(dt.Rows[0][33]);
                    ing.Pan = Escape.getBoolean(dt.Rows[0][34]);
                    ing.Arroz = Escape.getBoolean(dt.Rows[0][35]);
                    ing.Pasta = Escape.getBoolean(dt.Rows[0][36]);
                    ing.Pescado = Escape.getBoolean(dt.Rows[0][37]);
                    ing.Carne = Escape.getBoolean(dt.Rows[0][38]);
                    ing.Pollo = Escape.getBoolean(dt.Rows[0][39]);
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
        return ing;
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

                    query = "SELECT COUNT(VN_INGREDIENT.ID_DISH) " +
                            "FROM VN_INGREDIENT";
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

    #region "IEquatable(Of Ingrediente) Members"
    public bool Equals(Ingrediente other)
    {
        if (!Escape.IsNull(this) && !Escape.IsNull(other) && !Escape.IsNull(this.Plato) && !Escape.IsNull(other.Plato))
        {
            return this.Plato.Id == other.Plato.Id;
        }
        else
        {
            if ((Escape.IsNull(this) && Escape.IsNull(other)) || (Escape.IsNull(this.Plato) && Escape.IsNull(other.Plato)))
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
        if ((obj is Ingrediente))
        {
            return Equals((Ingrediente)obj);
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

    public static bool operator ==(Ingrediente u1, Ingrediente u2)
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

    public static bool operator !=(Ingrediente u1, Ingrediente u2)
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

    #region "IComparable(Of Ingrediente) Members"
    public int CompareTo(Ingrediente other)
    {
        if (!Escape.IsNull(this) && !Escape.IsNull(other) && !Escape.IsNull(this.Plato) && !Escape.IsNull(other.Plato))
        {
            return this.Plato.Id.CompareTo(other.Plato.Id);
        }
        else
        {
            if ((Escape.IsNull(this) && Escape.IsNull(other)) || (Escape.IsNull(this.Plato) && Escape.IsNull(other.Plato)))
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

    public Ingrediente()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}
