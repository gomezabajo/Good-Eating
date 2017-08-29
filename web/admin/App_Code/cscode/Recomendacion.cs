using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Descripción breve de Recomendacion
/// </summary>
public class Recomendacion
{
    private static string QueryModelado(Modelado m)
    {
        string query = string.Empty;
        if (m.Lactosa == true)
        {
            query += "AND VN_INGREDIENT.LACTOSE = FALSE ";
        }
        if (m.Num_fruta == 1)
        {
            query += "AND VN_INGREDIENT.FRUIT = FALSE ";
        }
        if (m.Esparrago == false)
        {
            query += "AND VN_INGREDIENT.ASPARAGUS = FALSE ";
        }
        if (m.Espinaca == false)
        {
            query += "AND VN_INGREDIENT.SPINACH = FALSE ";
        }
        if (m.Acelga == false)
        {
            query += "AND VN_INGREDIENT.CHARD = FALSE ";
        }
        if (m.Cardo == false)
        {
            query += "AND VN_INGREDIENT.THISTLE = FALSE ";
        }
        if (m.Borraja == false)
        {
            query += "AND VN_INGREDIENT.BORAGE = FALSE ";
        }
        if (m.Lechuga == false)
        {
            query += "AND VN_INGREDIENT.LETTUCE = FALSE ";
        }
        if (m.Pepinillo == false)
        {
            query += "AND VN_INGREDIENT.PICKLE = FALSE ";
        }
        if (m.Tomate == false)
        {
            query += "AND VN_INGREDIENT.TOMATO = FALSE ";
        }
        if (m.Pimiento == false)
        {
            query += "AND VN_INGREDIENT.PEPPER = FALSE ";
        }
        if (m.Berenjena == false)
        {
            query += "AND VN_INGREDIENT.EGGPLANT = FALSE ";
        }
        if (m.Calabacin == false)
        {
            query += "AND VN_INGREDIENT.ZUCCHINI = FALSE ";
        }
        if (m.Alcachofa == false)
        {
            query += "AND VN_INGREDIENT.ARTICHOKE = FALSE ";
        }
        if (m.Puerro == false)
        {
            query += "AND VN_INGREDIENT.LEEK = FALSE ";
        }
        if (m.Ajo == false)
        {
            query += "AND VN_INGREDIENT.GARLIC = FALSE ";
        }
        if (m.Cebolla == false)
        {
            query += "AND VN_INGREDIENT.ONION = FALSE ";
        }
        if (m.Nabo == false)
        {
            query += "AND VN_INGREDIENT.TURNIP = FALSE ";
        }
        if (m.Patata == false)
        {
            query += "AND VN_INGREDIENT.POTATO = FALSE ";
        }
        if (m.Rabanos == false)
        {
            query += "AND VN_INGREDIENT.RADISHES = FALSE ";
        }
        if (m.Remolacha == false)
        {
            query += "AND VN_INGREDIENT.BEET = FALSE ";
        }
        if (m.Zanahoria == false)
        {
            query += "AND VN_INGREDIENT.CARROT = FALSE ";
        }
        if (m.Judias == false)
        {
            query += "AND VN_INGREDIENT.GREENBEANS = FALSE ";
        }
        if (m.Guisantes == false)
        {
            query += "AND VN_INGREDIENT.PEAS = FALSE ";
        }
        if (m.Lentejas == false)
        {
            query += "AND VN_INGREDIENT.LENTILS = FALSE ";
        }
        if (m.Alubias == false)
        {
            query += "AND VN_INGREDIENT.BEANS = FALSE ";
        }
        if (m.Repollo == false)
        {
            query += "AND VN_INGREDIENT.CABBAGE = FALSE ";
        }
        if (m.Brecol == false)
        {
            query += "AND VN_INGREDIENT.BRECOL = FALSE ";
        }
        if (m.Coles == false)
        {
            query += "AND VN_INGREDIENT.BRUSSELSSPROUTS = FALSE ";
        }
        if (m.Coliflor == false)
        {
            query += "AND VN_INGREDIENT.CAULIFLOWER = FALSE ";
        }
        if (m.Champinnon == false)
        {
            query += "AND VN_INGREDIENT.BUTTONMUSHROOM = FALSE ";
        }
        if (m.Setas == false)
        {
            query += "AND VN_INGREDIENT.MUSHROOMS = FALSE ";
        }
        if (m.Huevos == false)
        {
            query += "AND VN_INGREDIENT.EGGS = FALSE ";
        }
        if (m.Pan == false)
        {
            query += "AND VN_INGREDIENT.BREAD = FALSE ";
        }
        if (m.Arroz == false)
        {
            query += "AND VN_INGREDIENT.RICE = FALSE ";
        }
        if (m.Pasta == false)
        {
            query += "AND VN_INGREDIENT.PASTA = FALSE ";
        }
        if (m.Pescado == false)
        {
            query += "AND VN_INGREDIENT.FISH = FALSE ";
        }
        if (m.Carne == false)
        {
            query += "AND VN_INGREDIENT.MEAT = FALSE ";
        }
        if (m.Pollo == false)
        {
            query += "AND VN_INGREDIENT.CHICKEN = FALSE ";
        }
        return query;
    }
    public static MenuDiario[] MenuDiario(int dias, Modelado m)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;

        string query = string.Empty;
        List<MenuDiario> mnds = new List<MenuDiario>();
        int id_menu = 0;
        Random rnd = new Random();

        try
        {
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return null;
                }

                if (m.Calorias < 2200)
                {
                    id_menu = 1;
                }
                else if (m.Calorias < 3000)
                {
                    id_menu = 2;
                }
                else
                {
                    id_menu = 3;
                }

                // desayuno (1º)
                List<Plato> desayunos = null;
                query = "SELECT VN_DISH.ID_DISH " +
                            "FROM VN_DISH, VN_INGREDIENT " +
                            "WHERE VN_DISH.ID_DISH = VN_INGREDIENT.ID_DISH " +
                            "AND VN_DISH.ID_TYPE_DISH = 1 " +
                            "AND VN_DISH.ID_MENU = " + id_menu + " ";
                query += QueryModelado(m);
                query += "ORDER BY VN_DISH.ID_DISH";

                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    desayunos = new List<Plato>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato desayuno = Plato.getById(Escape.getInt(dt.Rows[i][0]));

                        desayunos.Add(desayuno);
                    }
                }

                // comida (1º plato)
                List<Plato> comida_primeros = null;
                query = "SELECT VN_DISH.ID_DISH " +
                            "FROM VN_DISH, VN_INGREDIENT " +
                            "WHERE VN_DISH.ID_DISH = VN_INGREDIENT.ID_DISH " +
                            "AND VN_DISH.ID_TYPE_DISH = 2 " +
                            "AND VN_DISH.ID_MENU = " + id_menu + " ";
                query += QueryModelado(m);
                query += "ORDER BY VN_DISH.ID_DISH";

                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    comida_primeros = new List<Plato>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato comida_primero = Plato.getById(Escape.getInt(dt.Rows[i][0]));

                        comida_primeros.Add(comida_primero);
                    }
                }

                // comida (2º plato)
                List<Plato> comida_segundos = null;
                query = "SELECT VN_DISH.ID_DISH " +
                            "FROM VN_DISH, VN_INGREDIENT " +
                            "WHERE VN_DISH.ID_DISH = VN_INGREDIENT.ID_DISH " +
                            "AND VN_DISH.ID_TYPE_DISH = 3 " +
                            "AND VN_DISH.ID_MENU = " + id_menu + " ";
                query += QueryModelado(m);
                query += "ORDER BY VN_DISH.ID_DISH";

                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    comida_segundos = new List<Plato>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato comida_segundo = Plato.getById(Escape.getInt(dt.Rows[i][0]));

                        comida_segundos.Add(comida_segundo);
                    }
                }

                // comida (postre)
                List<Plato> comida_postres = null;
                query = "SELECT VN_DISH.ID_DISH " +
                            "FROM VN_DISH, VN_INGREDIENT " +
                            "WHERE VN_DISH.ID_DISH = VN_INGREDIENT.ID_DISH " +
                            "AND VN_DISH.ID_TYPE_DISH = 4 " +
                            "AND VN_DISH.ID_MENU = " + id_menu + " ";
                query += QueryModelado(m);
                query += "ORDER BY VN_DISH.ID_DISH";

                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    comida_postres = new List<Plato>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato comida_postre = Plato.getById(Escape.getInt(dt.Rows[i][0]));

                        comida_postres.Add(comida_postre);
                    }
                }
                // merienda
                List<Plato> meriendas = null;
                query = "SELECT VN_DISH.ID_DISH " +
                            "FROM VN_DISH, VN_INGREDIENT " +
                            "WHERE VN_DISH.ID_DISH = VN_INGREDIENT.ID_DISH " +
                            "AND VN_DISH.ID_TYPE_DISH = 5 " +
                            "AND VN_DISH.ID_MENU = " + id_menu + " ";
                query += QueryModelado(m);
                query += "ORDER BY VN_DISH.ID_DISH";

                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    meriendas = new List<Plato>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato merienda = Plato.getById(Escape.getInt(dt.Rows[i][0]));

                        meriendas.Add(merienda);
                    }
                }

                // cena (1º plato)
                List<Plato> cena_primeros = null;
                query = "SELECT VN_DISH.ID_DISH " +
                            "FROM VN_DISH, VN_INGREDIENT " +
                            "WHERE VN_DISH.ID_DISH = VN_INGREDIENT.ID_DISH " +
                            "AND VN_DISH.ID_TYPE_DISH = 6 " +
                            "AND VN_DISH.ID_MENU = " + id_menu + " ";
                query += QueryModelado(m);
                query += "ORDER BY VN_DISH.ID_DISH";

                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    cena_primeros = new List<Plato>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato cena_primero = Plato.getById(Escape.getInt(dt.Rows[i][0]));

                        cena_primeros.Add(cena_primero);
                    }
                }

                // cena (2º plato)
                List<Plato> cena_segundos = null;
                query = "SELECT VN_DISH.ID_DISH " +
                            "FROM VN_DISH, VN_INGREDIENT " +
                            "WHERE VN_DISH.ID_DISH = VN_INGREDIENT.ID_DISH " +
                            "AND VN_DISH.ID_TYPE_DISH = 7 " +
                            "AND VN_DISH.ID_MENU = " + id_menu + " ";
                query += QueryModelado(m);
                query += "ORDER BY VN_DISH.ID_DISH";

                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    cena_segundos = new List<Plato>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato cena_segundo = Plato.getById(Escape.getInt(dt.Rows[i][0]));

                        cena_segundos.Add(cena_segundo);
                    }
                }

                // cena (postre)
                List<Plato> cena_postres = null;
                query = "SELECT VN_DISH.ID_DISH " +
                            "FROM VN_DISH, VN_INGREDIENT " +
                            "WHERE VN_DISH.ID_DISH = VN_INGREDIENT.ID_DISH " +
                            "AND VN_DISH.ID_TYPE_DISH = 8 " +
                            "AND VN_DISH.ID_MENU = " + id_menu + " ";
                query += QueryModelado(m);
                query += "ORDER BY VN_DISH.ID_DISH";

                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    cena_postres = new List<Plato>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Plato cena_postre = Plato.getById(Escape.getInt(dt.Rows[i][0]));

                        cena_postres.Add(cena_postre);
                    }
                }

                List<Plato> desayunos_tmp = null;
                if (desayunos != null)
                {
                    if (desayunos.Count > 0)
                    {
                        desayunos_tmp = new List<Plato>();
                        for (int i = 0; i < desayunos.Count; i++)
                        {
                            desayunos_tmp.Add(desayunos[i]);
                        }
                    }
                }
                List<Plato> comida_primeros_tmp = null;
                if (comida_primeros != null)
                {
                    if (comida_primeros.Count > 0)
                    {
                        comida_primeros_tmp = new List<Plato>();
                        for (int i = 0; i < comida_primeros.Count; i++)
                        {
                            comida_primeros_tmp.Add(comida_primeros[i]);
                        }
                    }
                }
                List<Plato> comida_segundos_tmp = null;
                if (comida_segundos != null)
                {
                    if (comida_segundos.Count > 0)
                    {
                        comida_segundos_tmp = new List<Plato>();
                        for (int i = 0; i < comida_segundos.Count; i++)
                        {
                            comida_segundos_tmp.Add(comida_segundos[i]);
                        }
                    }
                }
                List<Plato> comida_postres_tmp = null;
                if (comida_postres != null)
                {
                    if (comida_postres.Count > 0)
                    {
                        comida_postres_tmp = new List<Plato>();
                        for (int i = 0; i < comida_postres.Count; i++)
                        {
                            comida_postres_tmp.Add(comida_postres[i]);
                        }
                    }
                }
                List<Plato> meriendas_tmp = null;
                if (meriendas != null)
                {
                    if (meriendas.Count > 0)
                    {
                        meriendas_tmp = new List<Plato>();
                        for (int i = 0; i < meriendas.Count; i++)
                        {
                            meriendas_tmp.Add(meriendas[i]);
                        }
                    }
                }
                List<Plato> cena_primeros_tmp = null;
                if (cena_primeros != null)
                {
                    if (cena_primeros.Count > 0)
                    {
                        cena_primeros_tmp = new List<Plato>();
                        for (int i = 0; i < cena_primeros.Count; i++)
                        {
                            cena_primeros_tmp.Add(cena_primeros[i]);
                        }
                    }
                }
                List<Plato> cena_segundos_tmp = null;
                if (cena_segundos != null)
                {
                    if (cena_segundos.Count > 0)
                    {
                        cena_segundos_tmp = new List<Plato>();
                        for (int i = 0; i < cena_segundos.Count; i++)
                        {
                            cena_segundos_tmp.Add(cena_segundos[i]);
                        }
                    }
                }
                List<Plato> cena_postres_tmp = null;
                if (cena_postres != null)
                {
                    if (cena_postres.Count > 0)
                    {
                        cena_postres_tmp = new List<Plato>();
                        for (int i = 0; i < cena_postres.Count; i++)
                        {
                            cena_postres_tmp.Add(cena_postres[i]);
                        }
                    }
                }
                // genera las recomendaciones
                for (int i = 0; i < dias; i++)
                {
                    MenuDiario mnd = new MenuDiario();
                    Plato desayuno_primero = null;
                    if (desayunos_tmp != null)
                    {
                        if (desayunos_tmp.Count > 0)
                        {
                            desayuno_primero = new Plato();
                            int index = rnd.Next(0, desayunos_tmp.Count - 1);
                            desayuno_primero.Id = desayunos_tmp[index].Id;
                            desayuno_primero.Menu = desayunos_tmp[index].Menu;
                            desayuno_primero.Tipo_plato = desayunos_tmp[index].Tipo_plato;
                            desayuno_primero.Nombre = desayunos_tmp[index].Nombre;
                            desayuno_primero.Ingrediente = desayunos_tmp[index].Ingrediente;

                            desayunos_tmp.Remove(desayunos_tmp[index]);
                            if (desayunos_tmp.Count == 0)
                            {
                                if (desayunos != null)
                                {
                                    if (desayunos.Count > 0)
                                    {
                                        desayunos_tmp = new List<Plato>();
                                        for (int j = 0; j < desayunos.Count; j++)
                                        {
                                            desayunos_tmp.Add(desayunos[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Desayuno_primero = desayuno_primero;
                    Plato desayuno_segundo = null;
                    if (desayunos_tmp != null)
                    {
                        if (desayunos_tmp.Count > 0)
                        {
                            desayuno_segundo = new Plato();
                            int index = rnd.Next(0, desayunos_tmp.Count - 1);
                            desayuno_segundo.Id = desayunos_tmp[index].Id;
                            desayuno_segundo.Menu = desayunos_tmp[index].Menu;
                            desayuno_segundo.Tipo_plato = desayunos_tmp[index].Tipo_plato;
                            desayuno_segundo.Nombre = desayunos_tmp[index].Nombre;
                            desayuno_segundo.Ingrediente = desayunos_tmp[index].Ingrediente;

                            desayunos_tmp.Remove(desayunos_tmp[index]);
                            if (desayunos_tmp.Count == 0)
                            {
                                if (desayunos != null)
                                {
                                    if (desayunos.Count > 0)
                                    {
                                        desayunos_tmp = new List<Plato>();
                                        for (int j = 0; j < desayunos.Count; j++)
                                        {
                                            desayunos_tmp.Add(desayunos[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Desayuno_segundo = desayuno_segundo;
                    Plato comida_primero = null;
                    if (comida_primeros_tmp != null)
                    {
                        if (comida_primeros_tmp.Count > 0)
                        {
                            comida_primero = new Plato();
                            int index = rnd.Next(0, comida_primeros_tmp.Count - 1);
                            comida_primero.Id = comida_primeros_tmp[index].Id;
                            comida_primero.Menu = comida_primeros_tmp[index].Menu;
                            comida_primero.Tipo_plato = comida_primeros_tmp[index].Tipo_plato;
                            comida_primero.Nombre = comida_primeros_tmp[index].Nombre;
                            comida_primero.Ingrediente = comida_primeros_tmp[index].Ingrediente;

                            comida_primeros_tmp.Remove(comida_primeros_tmp[index]);
                            if (comida_primeros_tmp.Count == 0)
                            {
                                if (comida_primeros != null)
                                {
                                    if (comida_primeros.Count > 0)
                                    {
                                        comida_primeros_tmp = new List<Plato>();
                                        for (int j = 0; j < comida_primeros.Count; j++)
                                        {
                                            comida_primeros_tmp.Add(comida_primeros[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Comida_primero = comida_primero;
                    Plato comida_segundo = null;
                    if (comida_segundos_tmp != null)
                    {
                        if (comida_segundos_tmp.Count > 0)
                        {
                            comida_segundo = new Plato();
                            int index = rnd.Next(0, comida_segundos_tmp.Count - 1);
                            comida_segundo.Id = comida_segundos_tmp[index].Id;
                            comida_segundo.Menu = comida_segundos_tmp[index].Menu;
                            comida_segundo.Tipo_plato = comida_segundos_tmp[index].Tipo_plato;
                            comida_segundo.Nombre = comida_segundos_tmp[index].Nombre;
                            comida_segundo.Ingrediente = comida_segundos_tmp[index].Ingrediente;

                            comida_segundos_tmp.Remove(comida_segundos_tmp[index]);
                            if (comida_segundos_tmp.Count == 0)
                            {
                                if (comida_segundos != null)
                                {
                                    if (comida_segundos.Count > 0)
                                    {
                                        comida_segundos_tmp = new List<Plato>();
                                        for (int j = 0; j < comida_segundos.Count; j++)
                                        {
                                            comida_segundos_tmp.Add(comida_segundos[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Comida_segundo = comida_segundo;
                    Plato comida_postre = null;
                    if (comida_postres_tmp != null)
                    {
                        if (comida_postres_tmp.Count > 0)
                        {
                            comida_postre = new Plato();
                            int index = rnd.Next(0, comida_postres_tmp.Count - 1);
                            comida_postre.Id = comida_postres_tmp[index].Id;
                            comida_postre.Menu = comida_postres_tmp[index].Menu;
                            comida_postre.Tipo_plato = comida_postres_tmp[index].Tipo_plato;
                            comida_postre.Nombre = comida_postres_tmp[index].Nombre;
                            comida_postre.Ingrediente = comida_postres_tmp[index].Ingrediente;

                            comida_postres_tmp.Remove(comida_postres_tmp[index]);
                            if (comida_postres_tmp.Count == 0)
                            {
                                if (comida_postres != null)
                                {
                                    if (comida_postres.Count > 0)
                                    {
                                        comida_postres_tmp = new List<Plato>();
                                        for (int j = 0; j < comida_postres.Count; j++)
                                        {
                                            comida_postres_tmp.Add(comida_postres[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Comida_postre = comida_postre;

                    Plato merienda_primero = null;
                    if (meriendas_tmp != null)
                    {
                        if (meriendas_tmp.Count > 0)
                        {
                            merienda_primero = new Plato();
                            int index = rnd.Next(0, meriendas_tmp.Count - 1);
                            merienda_primero.Id = meriendas_tmp[index].Id;
                            merienda_primero.Menu = meriendas_tmp[index].Menu;
                            merienda_primero.Tipo_plato = meriendas_tmp[index].Tipo_plato;
                            merienda_primero.Nombre = meriendas_tmp[index].Nombre;
                            merienda_primero.Ingrediente = meriendas_tmp[index].Ingrediente;

                            meriendas_tmp.Remove(meriendas_tmp[index]);
                            if (meriendas_tmp.Count == 0)
                            {
                                if (meriendas != null)
                                {
                                    if (meriendas.Count > 0)
                                    {
                                        meriendas_tmp = new List<Plato>();
                                        for (int j = 0; j < meriendas.Count; j++)
                                        {
                                            meriendas_tmp.Add(meriendas[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Merienda_primero = merienda_primero;
                    Plato merienda_segundo = null;
                    if (meriendas_tmp != null)
                    {
                        if (meriendas_tmp.Count > 0)
                        {
                            merienda_segundo = new Plato();
                            int index = rnd.Next(0, meriendas_tmp.Count - 1);
                            merienda_segundo.Id = meriendas_tmp[index].Id;
                            merienda_segundo.Menu = meriendas_tmp[index].Menu;
                            merienda_segundo.Tipo_plato = meriendas_tmp[index].Tipo_plato;
                            merienda_segundo.Nombre = meriendas_tmp[index].Nombre;
                            merienda_segundo.Ingrediente = meriendas_tmp[index].Ingrediente;

                            meriendas_tmp.Remove(meriendas_tmp[index]);
                            if (meriendas_tmp.Count == 0)
                            {
                                if (meriendas != null)
                                {
                                    if (meriendas.Count > 0)
                                    {
                                        meriendas_tmp = new List<Plato>();
                                        for (int j = 0; j < meriendas.Count; j++)
                                        {
                                            meriendas_tmp.Add(meriendas[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Merienda_segundo = merienda_segundo;
                    Plato cena_primero = null;
                    if (cena_primeros_tmp != null)
                    {
                        if (cena_primeros_tmp.Count > 0)
                        {
                            cena_primero = new Plato();
                            int index = rnd.Next(0, cena_primeros_tmp.Count - 1);
                            cena_primero.Id = cena_primeros_tmp[index].Id;
                            cena_primero.Menu = cena_primeros_tmp[index].Menu;
                            cena_primero.Tipo_plato = cena_primeros_tmp[index].Tipo_plato;
                            cena_primero.Nombre = cena_primeros_tmp[index].Nombre;
                            cena_primero.Ingrediente = cena_primeros_tmp[index].Ingrediente;

                            cena_primeros_tmp.Remove(cena_primeros_tmp[index]);
                            if (cena_primeros_tmp.Count == 0)
                            {
                                if (cena_primeros != null)
                                {
                                    if (cena_primeros.Count > 0)
                                    {
                                        cena_primeros_tmp = new List<Plato>();
                                        for (int j = 0; j < cena_primeros.Count; j++)
                                        {
                                            cena_primeros_tmp.Add(cena_primeros[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Cena_primero = cena_primero;
                    Plato cena_segundo = null;
                    if (cena_segundos_tmp != null)
                    {
                        if (cena_segundos_tmp.Count > 0)
                        {
                            cena_segundo = new Plato();
                            int index = rnd.Next(0, cena_segundos_tmp.Count - 1);
                            cena_segundo.Id = cena_segundos_tmp[index].Id;
                            cena_segundo.Menu = cena_segundos_tmp[index].Menu;
                            cena_segundo.Tipo_plato = cena_segundos_tmp[index].Tipo_plato;
                            cena_segundo.Nombre = cena_segundos_tmp[index].Nombre;
                            cena_segundo.Ingrediente = cena_segundos_tmp[index].Ingrediente;

                            cena_segundos_tmp.Remove(cena_segundos_tmp[index]);
                            if (cena_segundos_tmp.Count == 0)
                            {
                                if (cena_segundos != null)
                                {
                                    if (cena_segundos.Count > 0)
                                    {
                                        cena_segundos_tmp = new List<Plato>();
                                        for (int j = 0; j < cena_segundos.Count; j++)
                                        {
                                            cena_segundos_tmp.Add(cena_segundos[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Cena_segundo = cena_segundo;
                    Plato cena_postre = null;
                    if (cena_postres_tmp != null)
                    {
                        if (cena_postres_tmp.Count > 0)
                        {
                            cena_postre = new Plato();
                            int index = rnd.Next(0, cena_postres_tmp.Count - 1);
                            cena_postre.Id = cena_postres_tmp[index].Id;
                            cena_postre.Menu = cena_postres_tmp[index].Menu;
                            cena_postre.Tipo_plato = cena_postres_tmp[index].Tipo_plato;
                            cena_postre.Nombre = cena_postres_tmp[index].Nombre;
                            cena_postre.Ingrediente = cena_postres_tmp[index].Ingrediente;

                            cena_postres_tmp.Remove(cena_postres_tmp[index]);
                            if (cena_postres_tmp.Count == 0)
                            {
                                if (cena_postres != null)
                                {
                                    if (cena_postres.Count > 0)
                                    {
                                        cena_postres_tmp = new List<Plato>();
                                        for (int j = 0; j < cena_postres.Count; j++)
                                        {
                                            cena_postres_tmp.Add(cena_postres[j]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    mnd.Cena_postre = cena_postre;

                    mnds.Add(mnd);
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
        return mnds.ToArray<MenuDiario>();
    }

    public Recomendacion()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}