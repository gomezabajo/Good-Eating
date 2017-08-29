using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Descripción breve de Modelado
/// </summary>
public class Modelado
{
    public int Id;
    public Usuario Usuario;
    public bool Genero;
    public Edad Edad;
    public string Estatura;
    public string Peso;
    public int Num_comidas;
    public string Religion;
    public Pais Pais;
    public bool Diabetes;
    public bool Colesterol;
    public bool Hepatica;
    public bool Renal;
    public bool Pancreas;
    public bool Bilis;
    public bool Ulcera;
    public bool Colitis;
    public bool Colon;
    public bool Intestino;
    public int Num_fruta;
    public bool Platano;
    public bool Cereza;
    public bool Ciruela;
    public bool Guayaba;
    public bool Guanabana;
    public bool Higo;
    public bool Pera;
    public bool Albaricoque;
    public bool Limon;
    public bool Naranja;
    public bool Pinna;
    public bool Tamarindo;
    public bool Toronja;
    public bool Uva;
    public bool Manzana;
    public bool Melocoton;
    public bool Fresa;
    public bool Mandarina;
    public bool Lima;
    public bool Aguacate;
    public bool Aceituna;
    public bool Avellana;
    public bool Coco;
    public bool Nuez;
    public bool Cacao;
    public bool Durazno;
    public bool Lactosa;
    public int Num_lactosa;
    public int Num_verd;
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
    public bool Tipo;
    public bool Pescado;
    public bool Carne;
    public bool Pollo;
    public int Estilo;
    public int Presupuesto;

    private double IMC
    {
        get
        {
            if (this.Genero == true)
            {
                return 22.4;
            }
            else
            {
                return 20.9;
            }
        }
    }

    public double Peso_ideal
    {
        get
        {
            double estatura = Escape.getDouble(this.Estatura);
            return (estatura * estatura * IMC);
        }
    }

    public string Complexion
    {
        get
        {
            if ((this.Peso == string.Empty) || (this.Estatura == string.Empty))
            {
                return string.Empty;
            }
            double peso = Escape.getDouble(this.Peso);
            double estatura = Escape.getDouble(this.Estatura);

            if ((peso == 0) || (estatura == 0))
            {
                return string.Empty;
            }

            double complexion = peso / (estatura * estatura);

            if (complexion < 18)
            {
                return "Low weight";
            }
            else if (complexion < 25)
            {
                return "Normal weight";
            }
            else if (complexion < 27)
            {
                return "Overweight I";
            }
            else if (complexion < 30)
            {
                return "Overweight II";
            }
            else if (complexion < 35)
            {
                return "Obesity Type I";
            }
            else if (complexion < 40)
            {
                return "Obesity Type II";
            }
            else if (complexion < 50)
            {
                return "Obesity Type III";
            }
            else
            {
                return "Extreme Obesity 50";
            }
        }
    }

    public int Calorias
    {
        get
        {
            double cal = 0.0;
            switch (this.Estilo)
            {
                case 1:
                    cal = this.Peso_ideal * 30;
                    return (int)cal;
                case 2:
                    cal = this.Peso_ideal * 35;
                    return (int)cal;
                case 3:
                    cal = this.Peso_ideal * 40;
                    return (int)cal;
                default:
                    cal = this.Peso_ideal * 30;
                    return (int)cal;
            }
        }
    }

    public static Modelado[] Modelados
    {
        get
        {
            OdbcDataAdapter da = null;
            DataTable dt = null;

            string query = string.Empty;
            List<Modelado> md = new List<Modelado>();

            try
            {
                // conecta a la base de datos
                if (Common.ActiveConnection != null)
                {
                    if (Common.ActiveConnection.TryOpen() == false)
                    {
                        return null;
                    }

                    query = "SELECT VN_MODELLING.ID_MODELLING, VN_MODELLING.ID_USER, VN_MODELLING.SEX, VN_MODELLING.ID_AGE, VN_MODELLING.HEIGHT, VN_MODELLING.WEIGHT, " +
                                "VN_MODELLING.NUM_MEALS, VN_MODELLING.RELIGION, VN_MODELLING.ID_COUNTRY, VN_MODELLING.DIABETES, VN_MODELLING.CHOLESTEROL, VN_MODELLING.HEPATIC, " +
                                "VN_MODELLING.RENAL, VN_MODELLING.PANCREAS, VN_MODELLING.BILE, VN_MODELLING.ULCER, VN_MODELLING.COLITIS, VN_MODELLING.COLON, VN_MODELLING.INTESTINE, " +
                                "VN_MODELLING.NUM_FRUIT, VN_MODELLING.BANANA, VN_MODELLING.CHERRY, VN_MODELLING.PLUM, VN_MODELLING.GUAVA, VN_MODELLING.SOURSOP, VN_MODELLING.FIG, " +
                                "VN_MODELLING.PEAR, VN_MODELLING.APRICOT, VN_MODELLING.LEMON, VN_MODELLING.ORANGE, VN_MODELLING.PINEAPPLE, VN_MODELLING.TAMARIND, VN_MODELLING.GRAPEFRUIT, " +
                                "VN_MODELLING.GRAPE, VN_MODELLING.APPLE, VN_MODELLING.PEACH, VN_MODELLING.STRAWBERRY, VN_MODELLING.TANGERINE, VN_MODELLING.LIME, VN_MODELLING.AVOCADO, " +
                                "VN_MODELLING.OLIVE, VN_MODELLING.HAZELNUT, VN_MODELLING.COCONUT, VN_MODELLING.NUT, VN_MODELLING.COCOA, VN_MODELLING.SMALLPEACH, VN_MODELLING.LACTOSE, " +
                                "VN_MODELLING.NUM_LACTOSE, VN_MODELLING.NUM_GREEN, VN_MODELLING.ASPARAGUS, VN_MODELLING.SPINACH, VN_MODELLING.CHARD, VN_MODELLING.THISTLE, " +
                                "VN_MODELLING.BORAGE, VN_MODELLING.LETTUCE, VN_MODELLING.PICKLE, VN_MODELLING.TOMATO, VN_MODELLING.PEPPER, VN_MODELLING.EGGPLANT, VN_MODELLING.ZUCCHINI, " +
                                "VN_MODELLING.ARTICHOKE, VN_MODELLING.LEEK, VN_MODELLING.GARLIC, VN_MODELLING.ONION, VN_MODELLING.TURNIP, VN_MODELLING.POTATO, VN_MODELLING.RADISHES, " +
                                "VN_MODELLING.CARROT, VN_MODELLING.GREENBEANS, VN_MODELLING.PEAS, VN_MODELLING.LENTILS, VN_MODELLING.BEANS, VN_MODELLING.CABBAGE, VN_MODELLING.BRECOL, VN_MODELLING.BRUSSELSSPROUTS, " +
                                "VN_MODELLING.CAULIFLOWER, VN_MODELLING.BEET, VN_MODELLING.BUTTONMUSHROOM, VN_MODELLING.MUSHROOMS, VN_MODELLING.EGGS, VN_MODELLING.BREAD, VN_MODELLING.RICE, VN_MODELLING.PASTA, " +
                                "VN_MODELLING.TYPE_EATER, VN_MODELLING.FISH, VN_MODELLING.MEAT, VN_MODELLING.CHICKEN, VN_MODELLING.STYLE, VN_MODELLING.BUDGET " +
                                "FROM VN_MODELLING " +
                                "ORDER BY VN_MODELLING.ID_MODELLING";
                    da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Modelado m = new Modelado();
                        m.Id = Escape.getInt(dt.Rows[i][0]);
                        m.Usuario = Usuario.getById(Escape.getInt(dt.Rows[i][1]));
                        m.Genero = Escape.getBoolean(dt.Rows[i][2]);
                        m.Edad = Edad.getById(Escape.getInt(dt.Rows[i][3]));
                        m.Estatura = Escape.getString(dt.Rows[i][4]);
                        m.Peso = Escape.getString(dt.Rows[i][5]);
                        m.Num_comidas = Escape.getInt(dt.Rows[i][6]);
                        m.Religion = Escape.getString(dt.Rows[i][7]);
                        m.Pais = Pais.getById(Escape.getInt(dt.Rows[i][8]));
                        m.Diabetes = Escape.getBoolean(dt.Rows[i][9]);
                        m.Colesterol = Escape.getBoolean(dt.Rows[i][10]);
                        m.Hepatica = Escape.getBoolean(dt.Rows[i][11]);
                        m.Renal = Escape.getBoolean(dt.Rows[i][12]);
                        m.Pancreas = Escape.getBoolean(dt.Rows[i][13]);
                        m.Bilis = Escape.getBoolean(dt.Rows[i][14]);
                        m.Ulcera = Escape.getBoolean(dt.Rows[i][15]);
                        m.Colitis = Escape.getBoolean(dt.Rows[i][16]);
                        m.Colon = Escape.getBoolean(dt.Rows[i][17]);
                        m.Intestino = Escape.getBoolean(dt.Rows[i][18]);
                        m.Num_fruta  = Escape.getInt(dt.Rows[i][19]);
                        m.Platano = Escape.getBoolean(dt.Rows[i][20]);
                        m.Cereza = Escape.getBoolean(dt.Rows[i][21]);
                        m.Ciruela = Escape.getBoolean(dt.Rows[i][22]);
                        m.Guayaba = Escape.getBoolean(dt.Rows[i][23]);
                        m.Guanabana = Escape.getBoolean(dt.Rows[i][24]);
                        m.Higo = Escape.getBoolean(dt.Rows[i][25]);
                        m.Pera = Escape.getBoolean(dt.Rows[i][26]);
                        m.Albaricoque = Escape.getBoolean(dt.Rows[i][27]);
                        m.Limon = Escape.getBoolean(dt.Rows[i][28]);
                        m.Naranja = Escape.getBoolean(dt.Rows[i][29]);
                        m.Pinna = Escape.getBoolean(dt.Rows[i][30]);
                        m.Tamarindo = Escape.getBoolean(dt.Rows[i][31]);
                        m.Toronja = Escape.getBoolean(dt.Rows[i][32]);
                        m.Uva = Escape.getBoolean(dt.Rows[i][33]);
                        m.Manzana = Escape.getBoolean(dt.Rows[i][34]);
                        m.Melocoton = Escape.getBoolean(dt.Rows[i][35]);
                        m.Fresa = Escape.getBoolean(dt.Rows[i][36]);
                        m.Mandarina = Escape.getBoolean(dt.Rows[i][37]);
                        m.Lima = Escape.getBoolean(dt.Rows[i][38]);
                        m.Aguacate = Escape.getBoolean(dt.Rows[i][39]);
                        m.Aceituna = Escape.getBoolean(dt.Rows[i][40]);
                        m.Avellana = Escape.getBoolean(dt.Rows[i][41]);
                        m.Coco = Escape.getBoolean(dt.Rows[i][42]);
                        m.Nuez = Escape.getBoolean(dt.Rows[i][43]);
                        m.Cacao = Escape.getBoolean(dt.Rows[i][44]);
                        m.Durazno = Escape.getBoolean(dt.Rows[i][45]);
                        m.Lactosa = Escape.getBoolean(dt.Rows[i][46]);
                        m.Num_lactosa = Escape.getInt(dt.Rows[i][47]);
                        m.Num_verd = Escape.getInt(dt.Rows[i][48]);
                        m.Esparrago = Escape.getBoolean(dt.Rows[i][49]);
                        m.Espinaca = Escape.getBoolean(dt.Rows[i][50]);
                        m.Acelga = Escape.getBoolean(dt.Rows[i][51]);
                        m.Cardo = Escape.getBoolean(dt.Rows[i][52]);
                        m.Borraja = Escape.getBoolean(dt.Rows[i][53]);
                        m.Lechuga = Escape.getBoolean(dt.Rows[i][54]);
                        m.Pepinillo = Escape.getBoolean(dt.Rows[i][55]);
                        m.Tomate = Escape.getBoolean(dt.Rows[i][56]);
                        m.Pimiento = Escape.getBoolean(dt.Rows[i][57]);
                        m.Berenjena = Escape.getBoolean(dt.Rows[i][58]);
                        m.Calabacin = Escape.getBoolean(dt.Rows[i][59]);
                        m.Alcachofa = Escape.getBoolean(dt.Rows[i][60]);
                        m.Puerro = Escape.getBoolean(dt.Rows[i][61]);
                        m.Ajo = Escape.getBoolean(dt.Rows[i][62]);
                        m.Cebolla = Escape.getBoolean(dt.Rows[i][63]);
                        m.Nabo = Escape.getBoolean(dt.Rows[i][64]);
                        m.Patata = Escape.getBoolean(dt.Rows[i][65]);
                        m.Rabanos = Escape.getBoolean(dt.Rows[i][66]);
                        m.Remolacha = Escape.getBoolean(dt.Rows[i][67]);
                        m.Zanahoria = Escape.getBoolean(dt.Rows[i][68]);
                        m.Judias = Escape.getBoolean(dt.Rows[i][69]);
                        m.Guisantes = Escape.getBoolean(dt.Rows[i][70]);
                        m.Lentejas = Escape.getBoolean(dt.Rows[i][71]);
                        m.Alubias = Escape.getBoolean(dt.Rows[i][72]);
                        m.Repollo = Escape.getBoolean(dt.Rows[i][73]);
                        m.Brecol = Escape.getBoolean(dt.Rows[i][74]);
                        m.Coles = Escape.getBoolean(dt.Rows[i][75]);
                        m.Coliflor = Escape.getBoolean(dt.Rows[i][76]);
                        m.Champinnon = Escape.getBoolean(dt.Rows[i][77]);
                        m.Setas = Escape.getBoolean(dt.Rows[i][78]);
                        m.Huevos = Escape.getBoolean(dt.Rows[i][79]);
                        m.Pan = Escape.getBoolean(dt.Rows[i][80]);
                        m.Arroz = Escape.getBoolean(dt.Rows[i][81]);
                        m.Pasta = Escape.getBoolean(dt.Rows[i][82]);
                        m.Tipo = Escape.getBoolean(dt.Rows[i][83]);
                        m.Pescado = Escape.getBoolean(dt.Rows[i][84]);
                        m.Carne = Escape.getBoolean(dt.Rows[i][85]);
                        m.Pollo = Escape.getBoolean(dt.Rows[i][86]);
                        m.Estilo = Escape.getInt(dt.Rows[i][87]);
                        m.Presupuesto = Escape.getInt(dt.Rows[i][88]);

                        md.Add(m);
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
            return md.ToArray<Modelado>();
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
            // conecta a la base de datos
            if (Common.ActiveConnection != null)
            {
                if (Common.ActiveConnection.TryOpen() == false)
                {
                    return;
                }

                //obtiene el siguiente identificador para los datos del modelado
                query = "SELECT MAX(VN_MODELLING.ID_MODELLING) AS \"CERO\" FROM VN_MODELLING";
                da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                int idmodelado = 1;
                if (dt.Rows.Count > 0)
                {
                    idmodelado = (Escape.getInt(dt.Rows[0][0]) < 0) ? 1 : Escape.getInt(dt.Rows[0][0]) + 1;
                }


                // comienza la transacción
                t = Common.ActiveConnection.Connection.BeginTransaction();
                c = new OdbcCommand();
                c.Connection = Common.ActiveConnection.Connection;
                c.Transaction = t;

                c.CommandText = "INSERT INTO VN_MODELLING (VN_MODELLING.ID_MODELLING, VN_MODELLING.ID_USER, VN_MODELLING.SEX, VN_MODELLING.ID_AGE, VN_MODELLING.HEIGHT, VN_MODELLING.WEIGHT, " +
                                    "VN_MODELLING.NUM_MEALS, VN_MODELLING.RELIGION, VN_MODELLING.ID_COUNTRY, VN_MODELLING.DIABETES, VN_MODELLING.CHOLESTEROL, VN_MODELLING.HEPATIC, " +
                                    "VN_MODELLING.RENAL, VN_MODELLING.PANCREAS, VN_MODELLING.BILE, VN_MODELLING.ULCER, VN_MODELLING.COLITIS, VN_MODELLING.COLON, VN_MODELLING.INTESTINE, " +
                                    "VN_MODELLING.NUM_FRUIT, VN_MODELLING.BANANA, VN_MODELLING.CHERRY, VN_MODELLING.PLUM, VN_MODELLING.GUAVA, VN_MODELLING.SOURSOP, VN_MODELLING.FIG, " +
                                    "VN_MODELLING.PEAR, VN_MODELLING.APRICOT, VN_MODELLING.LEMON, VN_MODELLING.ORANGE, VN_MODELLING.PINEAPPLE, VN_MODELLING.TAMARIND, VN_MODELLING.GRAPEFRUIT, " +
                                    "VN_MODELLING.GRAPE, VN_MODELLING.APPLE, VN_MODELLING.PEACH, VN_MODELLING.STRAWBERRY, VN_MODELLING.TANGERINE, VN_MODELLING.LIME, VN_MODELLING.AVOCADO, " +
                                    "VN_MODELLING.OLIVE, VN_MODELLING.HAZELNUT, VN_MODELLING.COCONUT, VN_MODELLING.NUT, VN_MODELLING.COCOA, VN_MODELLING.SMALLPEACH, VN_MODELLING.LACTOSE, " +
                                    "VN_MODELLING.NUM_LACTOSE, VN_MODELLING.NUM_GREEN, VN_MODELLING.ASPARAGUS, VN_MODELLING.SPINACH, VN_MODELLING.CHARD, VN_MODELLING.THISTLE, " +
                                    "VN_MODELLING.BORAGE, VN_MODELLING.LETTUCE, VN_MODELLING.PICKLE, VN_MODELLING.TOMATO, VN_MODELLING.PEPPER, VN_MODELLING.EGGPLANT, VN_MODELLING.ZUCCHINI, " +
                                    "VN_MODELLING.ARTICHOKE, VN_MODELLING.LEEK, VN_MODELLING.GARLIC, VN_MODELLING.ONION, VN_MODELLING.TURNIP, VN_MODELLING.POTATO, VN_MODELLING.RADISHES, " +
                                    "VN_MODELLING.CARROT, VN_MODELLING.GREENBEANS, VN_MODELLING.PEAS, VN_MODELLING.LENTILS, VN_MODELLING.BEANS, VN_MODELLING.CABBAGE, VN_MODELLING.BRECOL, VN_MODELLING.BRUSSELSSPROUTS, " +
                                    "VN_MODELLING.CAULIFLOWER, VN_MODELLING.BEET, VN_MODELLING.BUTTONMUSHROOM, VN_MODELLING.MUSHROOMS, VN_MODELLING.EGGS, VN_MODELLING.BREAD, VN_MODELLING.RICE, VN_MODELLING.PASTA, " +
                                    "VN_MODELLING.TYPE_EATER, VN_MODELLING.FISH, VN_MODELLING.MEAT, VN_MODELLING.CHICKEN, VN_MODELLING.STYLE, VN_MODELLING.BUDGET) " +
                                    "VALUES (" + idmodelado + ", ";
                if (this.Usuario != null)
                {
                    c.CommandText += this.Usuario.Id + ", ";
                }
                else
                {
                    c.CommandText += "NULL, ";
                }
                c.CommandText += this.Genero + ", ";
                if (this.Edad != null)
                {
                    c.CommandText += this.Edad.Id + ", ";
                }
                else
                {
                    c.CommandText += "NULL, ";
                }
                c.CommandText += "'" + Escape.MySql(this.Estatura) + "', '" + Escape.MySql(this.Peso) + "', " + this.Num_comidas + ", " + 
                    "'" + Escape.MySql(this.Religion) + "', ";
                if (this.Pais != null)
                {
                    c.CommandText += this.Pais.Id + ", ";
                }
                else
                {
                    c.CommandText += "NULL, ";
                }
                c.CommandText += this.Diabetes + ", " + this.Colesterol + ", " + this.Hepatica + ", " + this.Renal + ", " + this.Pancreas + ", " +
                    this.Bilis + ", " +  this.Ulcera + ", " + this.Colitis + ", " + this.Colon + ", " + this.Intestino + ", " + this.Num_fruta + ", " +
                    this.Platano + ", " + this.Cereza + ", " + this.Ciruela + ", " + this.Guayaba + ", " + this.Guanabana + ", " + this.Higo + ", " +
                    this.Pera + ", " + this.Albaricoque + ", " + this.Limon + ", " + this.Naranja + ", " + this.Pinna + ", " + this.Tamarindo + ", " +
                    this.Toronja + ", " + this.Uva + ", " + this.Manzana + ", " + this.Melocoton + ", " + this.Fresa + ", " + this.Mandarina + ", " +
                    this.Lima + ", " + this.Aguacate + ", " + this.Aceituna + ", " + this.Avellana + ", " + this.Coco + ", " + this.Nuez + ", " +
                    this.Cacao + ", " + this.Durazno + ", " + this.Lactosa + ", " + this.Num_lactosa + ", " + this.Num_verd + ", " + this.Esparrago + ", " +
                    this.Espinaca + ", " + this.Acelga + ", " + this.Cardo + ", " + this.Borraja + ", " + this.Lechuga + ", " + this.Pepinillo + ", " +
                    this.Tomate + ", " + this.Pimiento + ", " + this.Berenjena + ", " + this.Calabacin + ", " + this.Alcachofa + ", " + this.Puerro + ", " + this.Ajo + ", " +
                    this.Cebolla + ", " + this.Nabo + ", " + this.Patata + ", " + this.Rabanos + ", " + this.Remolacha + ", " + this.Zanahoria + ", " +
                    this.Judias + ", " + this.Guisantes + ", " + this.Lentejas + ", " + this.Alubias + ", " + this.Repollo + ", " + this.Brecol + ", " + this.Coles + ", " +
                    this.Coliflor + ", " + this.Champinnon + ", " + this.Setas + ", " + this.Huevos + ", " + this.Pan + ", " + this.Arroz + ", " + this.Pasta + ", " +
                    this.Tipo + ", " + this.Pescado + ", " + this.Carne + ", " + this.Pollo + ", " + this.Estilo + ", " + this.Presupuesto + ")";

                c.ExecuteNonQuery();
                t.Commit();
                t = null;

                this.Id = idmodelado;

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
                c.CommandText = "DELETE FROM VN_MODELLING WHERE VN_MODELLING.ID_MODELLING = " + this.Id;
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

    public static Modelado getById(int id)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Modelado m = null;

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
            query = "SELECT VN_MODELLING.ID_MODELLING, VN_MODELLING.ID_USER, VN_MODELLING.SEX, VN_MODELLING.ID_AGE, VN_MODELLING.HEIGHT, VN_MODELLING.WEIGHT, " +
                        "VN_MODELLING.NUM_MEALS, VN_MODELLING.RELIGION, VN_MODELLING.ID_COUNTRY, VN_MODELLING.DIABETES, VN_MODELLING.CHOLESTEROL, VN_MODELLING.HEPATIC, " +
                        "VN_MODELLING.RENAL, VN_MODELLING.PANCREAS, VN_MODELLING.BILE, VN_MODELLING.ULCER, VN_MODELLING.COLITIS, VN_MODELLING.COLON, VN_MODELLING.INTESTINE, " +
                        "VN_MODELLING.NUM_FRUIT, VN_MODELLING.BANANA, VN_MODELLING.CHERRY, VN_MODELLING.PLUM, VN_MODELLING.GUAVA, VN_MODELLING.SOURSOP, VN_MODELLING.FIG, " +
                        "VN_MODELLING.PEAR, VN_MODELLING.APRICOT, VN_MODELLING.LEMON, VN_MODELLING.ORANGE, VN_MODELLING.PINEAPPLE, VN_MODELLING.TAMARIND, VN_MODELLING.GRAPEFRUIT, " +
                        "VN_MODELLING.GRAPE, VN_MODELLING.APPLE, VN_MODELLING.PEACH, VN_MODELLING.STRAWBERRY, VN_MODELLING.TANGERINE, VN_MODELLING.LIME, VN_MODELLING.AVOCADO, " +
                        "VN_MODELLING.OLIVE, VN_MODELLING.HAZELNUT, VN_MODELLING.COCONUT, VN_MODELLING.NUT, VN_MODELLING.COCOA, VN_MODELLING.SMALLPEACH, VN_MODELLING.LACTOSE, " +
                        "VN_MODELLING.NUM_LACTOSE, VN_MODELLING.NUM_GREEN, VN_MODELLING.ASPARAGUS, VN_MODELLING.SPINACH, VN_MODELLING.CHARD, VN_MODELLING.THISTLE, " +
                        "VN_MODELLING.BORAGE, VN_MODELLING.LETTUCE, VN_MODELLING.PICKLE, VN_MODELLING.TOMATO, VN_MODELLING.PEPPER, VN_MODELLING.EGGPLANT, VN_MODELLING.ZUCCHINI, " +
                        "VN_MODELLING.ARTICHOKE, VN_MODELLING.LEEK, VN_MODELLING.GARLIC, VN_MODELLING.ONION, VN_MODELLING.TURNIP, VN_MODELLING.POTATO, VN_MODELLING.RADISHES, " +
                        "VN_MODELLING.CARROT, VN_MODELLING.GREENBEANS, VN_MODELLING.PEAS, VN_MODELLING.LENTILS, VN_MODELLING.BEANS, VN_MODELLING.CABBAGE, VN_MODELLING.BRECOL, VN_MODELLING.BRUSSELSSPROUTS, " +
                        "VN_MODELLING.CAULIFLOWER, VN_MODELLING.BEET, VN_MODELLING.BUTTONMUSHROOM, VN_MODELLING.MUSHROOMS, VN_MODELLING.EGGS, VN_MODELLING.BREAD, VN_MODELLING.RICE, VN_MODELLING.PASTA, " +
                        "VN_MODELLING.TYPE_EATER, VN_MODELLING.FISH, VN_MODELLING.MEAT, VN_MODELLING.CHICKEN, VN_MODELLING.STYLE, VN_MODELLING.BUDGET " +
                        "FROM VN_MODELLING " +
                        "WHERE VN_MODELLING.ID_MODELLING = " + id + " " +
                        "ORDER BY VN_MODELLING.ID_MODELLING";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                m = new Modelado();
                m.Id = Escape.getInt(dt.Rows[0][0]);
                m.Usuario = Usuario.getById(Escape.getInt(dt.Rows[0][1]));
                m.Genero = Escape.getBoolean(dt.Rows[0][2]);
                m.Edad = Edad.getById(Escape.getInt(dt.Rows[0][3]));
                m.Estatura = Escape.getString(dt.Rows[0][4]);
                m.Peso = Escape.getString(dt.Rows[0][5]);
                m.Num_comidas = Escape.getInt(dt.Rows[0][6]);
                m.Religion = Escape.getString(dt.Rows[0][7]);
                m.Pais = Pais.getById(Escape.getInt(dt.Rows[0][8]));
                m.Diabetes = Escape.getBoolean(dt.Rows[0][9]);
                m.Colesterol = Escape.getBoolean(dt.Rows[0][10]);
                m.Hepatica = Escape.getBoolean(dt.Rows[0][11]);
                m.Renal = Escape.getBoolean(dt.Rows[0][12]);
                m.Pancreas = Escape.getBoolean(dt.Rows[0][13]);
                m.Bilis = Escape.getBoolean(dt.Rows[0][14]);
                m.Ulcera = Escape.getBoolean(dt.Rows[0][15]);
                m.Colitis = Escape.getBoolean(dt.Rows[0][16]);
                m.Colon = Escape.getBoolean(dt.Rows[0][17]);
                m.Intestino = Escape.getBoolean(dt.Rows[0][18]);
                m.Num_fruta = Escape.getInt(dt.Rows[0][19]);
                m.Platano = Escape.getBoolean(dt.Rows[0][20]);
                m.Cereza = Escape.getBoolean(dt.Rows[0][21]);
                m.Ciruela = Escape.getBoolean(dt.Rows[0][22]);
                m.Guayaba = Escape.getBoolean(dt.Rows[0][23]);
                m.Guanabana = Escape.getBoolean(dt.Rows[0][24]);
                m.Higo = Escape.getBoolean(dt.Rows[0][25]);
                m.Pera = Escape.getBoolean(dt.Rows[0][26]);
                m.Albaricoque = Escape.getBoolean(dt.Rows[0][27]);
                m.Limon = Escape.getBoolean(dt.Rows[0][28]);
                m.Naranja = Escape.getBoolean(dt.Rows[0][29]);
                m.Pinna = Escape.getBoolean(dt.Rows[0][30]);
                m.Tamarindo = Escape.getBoolean(dt.Rows[0][31]);
                m.Toronja = Escape.getBoolean(dt.Rows[0][32]);
                m.Uva = Escape.getBoolean(dt.Rows[0][33]);
                m.Manzana = Escape.getBoolean(dt.Rows[0][34]);
                m.Melocoton = Escape.getBoolean(dt.Rows[0][35]);
                m.Fresa = Escape.getBoolean(dt.Rows[0][36]);
                m.Mandarina = Escape.getBoolean(dt.Rows[0][37]);
                m.Lima = Escape.getBoolean(dt.Rows[0][38]);
                m.Aguacate = Escape.getBoolean(dt.Rows[0][39]);
                m.Aceituna = Escape.getBoolean(dt.Rows[0][40]);
                m.Avellana = Escape.getBoolean(dt.Rows[0][41]);
                m.Coco = Escape.getBoolean(dt.Rows[0][42]);
                m.Nuez = Escape.getBoolean(dt.Rows[0][43]);
                m.Cacao = Escape.getBoolean(dt.Rows[0][44]);
                m.Durazno = Escape.getBoolean(dt.Rows[0][45]);
                m.Lactosa = Escape.getBoolean(dt.Rows[0][46]);
                m.Num_lactosa = Escape.getInt(dt.Rows[0][47]);
                m.Num_verd = Escape.getInt(dt.Rows[0][48]);
                m.Esparrago = Escape.getBoolean(dt.Rows[0][49]);
                m.Espinaca = Escape.getBoolean(dt.Rows[0][50]);
                m.Acelga = Escape.getBoolean(dt.Rows[0][51]);
                m.Cardo = Escape.getBoolean(dt.Rows[0][52]);
                m.Borraja = Escape.getBoolean(dt.Rows[0][53]);
                m.Lechuga = Escape.getBoolean(dt.Rows[0][54]);
                m.Pepinillo = Escape.getBoolean(dt.Rows[0][55]);
                m.Tomate = Escape.getBoolean(dt.Rows[0][56]);
                m.Pimiento = Escape.getBoolean(dt.Rows[0][57]);
                m.Berenjena = Escape.getBoolean(dt.Rows[0][58]);
                m.Calabacin = Escape.getBoolean(dt.Rows[0][59]);
                m.Alcachofa = Escape.getBoolean(dt.Rows[0][60]);
                m.Puerro = Escape.getBoolean(dt.Rows[0][61]);
                m.Ajo = Escape.getBoolean(dt.Rows[0][62]);
                m.Cebolla = Escape.getBoolean(dt.Rows[0][63]);
                m.Nabo = Escape.getBoolean(dt.Rows[0][64]);
                m.Patata = Escape.getBoolean(dt.Rows[0][65]);
                m.Rabanos = Escape.getBoolean(dt.Rows[0][66]);
                m.Remolacha = Escape.getBoolean(dt.Rows[0][67]);
                m.Zanahoria = Escape.getBoolean(dt.Rows[0][68]);
                m.Judias = Escape.getBoolean(dt.Rows[0][69]);
                m.Guisantes = Escape.getBoolean(dt.Rows[0][70]);
                m.Lentejas = Escape.getBoolean(dt.Rows[0][71]);
                m.Alubias = Escape.getBoolean(dt.Rows[0][72]);
                m.Repollo = Escape.getBoolean(dt.Rows[0][73]);
                m.Brecol = Escape.getBoolean(dt.Rows[0][74]);
                m.Coles = Escape.getBoolean(dt.Rows[0][75]);
                m.Coliflor = Escape.getBoolean(dt.Rows[0][76]);
                m.Champinnon = Escape.getBoolean(dt.Rows[0][77]);
                m.Setas = Escape.getBoolean(dt.Rows[0][78]);
                m.Huevos = Escape.getBoolean(dt.Rows[0][79]);
                m.Pan = Escape.getBoolean(dt.Rows[0][80]);
                m.Arroz = Escape.getBoolean(dt.Rows[0][81]);
                m.Pasta = Escape.getBoolean(dt.Rows[0][82]);
                m.Tipo = Escape.getBoolean(dt.Rows[0][83]);
                m.Pescado = Escape.getBoolean(dt.Rows[0][84]);
                m.Carne = Escape.getBoolean(dt.Rows[0][85]);
                m.Pollo = Escape.getBoolean(dt.Rows[0][86]);
                m.Estilo = Escape.getInt(dt.Rows[0][87]);
                m.Presupuesto = Escape.getInt(dt.Rows[0][88]);
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
        return m;
    }

    public static Modelado getByUsuario(int id_user)
    {
        OdbcDataAdapter da = null;
        DataTable dt = null;
        string query = string.Empty;

        Modelado m = null;

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
            query = "SELECT VN_MODELLING.ID_MODELLING, VN_MODELLING.ID_USER, VN_MODELLING.SEX, VN_MODELLING.ID_AGE, VN_MODELLING.HEIGHT, VN_MODELLING.WEIGHT, " +
                        "VN_MODELLING.NUM_MEALS, VN_MODELLING.RELIGION, VN_MODELLING.ID_COUNTRY, VN_MODELLING.DIABETES, VN_MODELLING.CHOLESTEROL, VN_MODELLING.HEPATIC, " +
                        "VN_MODELLING.RENAL, VN_MODELLING.PANCREAS, VN_MODELLING.BILE, VN_MODELLING.ULCER, VN_MODELLING.COLITIS, VN_MODELLING.COLON, VN_MODELLING.INTESTINE, " +
                        "VN_MODELLING.NUM_FRUIT, VN_MODELLING.BANANA, VN_MODELLING.CHERRY, VN_MODELLING.PLUM, VN_MODELLING.GUAVA, VN_MODELLING.SOURSOP, VN_MODELLING.FIG, " +
                        "VN_MODELLING.PEAR, VN_MODELLING.APRICOT, VN_MODELLING.LEMON, VN_MODELLING.ORANGE, VN_MODELLING.PINEAPPLE, VN_MODELLING.TAMARIND, VN_MODELLING.GRAPEFRUIT, " +
                        "VN_MODELLING.GRAPE, VN_MODELLING.APPLE, VN_MODELLING.PEACH, VN_MODELLING.STRAWBERRY, VN_MODELLING.TANGERINE, VN_MODELLING.LIME, VN_MODELLING.AVOCADO, " +
                        "VN_MODELLING.OLIVE, VN_MODELLING.HAZELNUT, VN_MODELLING.COCONUT, VN_MODELLING.NUT, VN_MODELLING.COCOA, VN_MODELLING.SMALLPEACH, VN_MODELLING.LACTOSE, " +
                        "VN_MODELLING.NUM_LACTOSE, VN_MODELLING.NUM_GREEN, VN_MODELLING.ASPARAGUS, VN_MODELLING.SPINACH, VN_MODELLING.CHARD, VN_MODELLING.THISTLE, " +
                        "VN_MODELLING.BORAGE, VN_MODELLING.LETTUCE, VN_MODELLING.PICKLE, VN_MODELLING.TOMATO, VN_MODELLING.PEPPER, VN_MODELLING.EGGPLANT, VN_MODELLING.ZUCCHINI, " +
                        "VN_MODELLING.ARTICHOKE, VN_MODELLING.LEEK, VN_MODELLING.GARLIC, VN_MODELLING.ONION, VN_MODELLING.TURNIP, VN_MODELLING.POTATO, VN_MODELLING.RADISHES, " +
                        "VN_MODELLING.CARROT, VN_MODELLING.GREENBEANS, VN_MODELLING.PEAS, VN_MODELLING.LENTILS, VN_MODELLING.BEANS, VN_MODELLING.CABBAGE, VN_MODELLING.BRECOL, VN_MODELLING.BRUSSELSSPROUTS, " +
                        "VN_MODELLING.CAULIFLOWER, VN_MODELLING.BEET, VN_MODELLING.BUTTONMUSHROOM, VN_MODELLING.MUSHROOMS, VN_MODELLING.EGGS, VN_MODELLING.BREAD, VN_MODELLING.RICE, VN_MODELLING.PASTA, " +
                        "VN_MODELLING.TYPE_EATER, VN_MODELLING.FISH, VN_MODELLING.MEAT, VN_MODELLING.CHICKEN, VN_MODELLING.STYLE, VN_MODELLING.BUDGET " +
                        "FROM VN_MODELLING " +
                        "WHERE VN_MODELLING.ID_USER = " + id_user + " " +
                        "ORDER BY VN_MODELLING.ID_MODELLING";
            da = new OdbcDataAdapter(query, Common.ActiveConnection.Connection);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                m = new Modelado();
                m.Id = Escape.getInt(dt.Rows[0][0]);
                m.Usuario = Usuario.getById(Escape.getInt(dt.Rows[0][1]));
                m.Genero = Escape.getBoolean(dt.Rows[0][2]);
                m.Edad = Edad.getById(Escape.getInt(dt.Rows[0][3]));
                m.Estatura = Escape.getString(dt.Rows[0][4]);
                m.Peso = Escape.getString(dt.Rows[0][5]);
                m.Num_comidas = Escape.getInt(dt.Rows[0][6]);
                m.Religion = Escape.getString(dt.Rows[0][7]);
                m.Pais = Pais.getById(Escape.getInt(dt.Rows[0][8]));
                m.Diabetes = Escape.getBoolean(dt.Rows[0][9]);
                m.Colesterol = Escape.getBoolean(dt.Rows[0][10]);
                m.Hepatica = Escape.getBoolean(dt.Rows[0][11]);
                m.Renal = Escape.getBoolean(dt.Rows[0][12]);
                m.Pancreas = Escape.getBoolean(dt.Rows[0][13]);
                m.Bilis = Escape.getBoolean(dt.Rows[0][14]);
                m.Ulcera = Escape.getBoolean(dt.Rows[0][15]);
                m.Colitis = Escape.getBoolean(dt.Rows[0][16]);
                m.Colon = Escape.getBoolean(dt.Rows[0][17]);
                m.Intestino = Escape.getBoolean(dt.Rows[0][18]);
                m.Num_fruta = Escape.getInt(dt.Rows[0][19]);
                m.Platano = Escape.getBoolean(dt.Rows[0][20]);
                m.Cereza = Escape.getBoolean(dt.Rows[0][21]);
                m.Ciruela = Escape.getBoolean(dt.Rows[0][22]);
                m.Guayaba = Escape.getBoolean(dt.Rows[0][23]);
                m.Guanabana = Escape.getBoolean(dt.Rows[0][24]);
                m.Higo = Escape.getBoolean(dt.Rows[0][25]);
                m.Pera = Escape.getBoolean(dt.Rows[0][26]);
                m.Albaricoque = Escape.getBoolean(dt.Rows[0][27]);
                m.Limon = Escape.getBoolean(dt.Rows[0][28]);
                m.Naranja = Escape.getBoolean(dt.Rows[0][29]);
                m.Pinna = Escape.getBoolean(dt.Rows[0][30]);
                m.Tamarindo = Escape.getBoolean(dt.Rows[0][31]);
                m.Toronja = Escape.getBoolean(dt.Rows[0][32]);
                m.Uva = Escape.getBoolean(dt.Rows[0][33]);
                m.Manzana = Escape.getBoolean(dt.Rows[0][34]);
                m.Melocoton = Escape.getBoolean(dt.Rows[0][35]);
                m.Fresa = Escape.getBoolean(dt.Rows[0][36]);
                m.Mandarina = Escape.getBoolean(dt.Rows[0][37]);
                m.Lima = Escape.getBoolean(dt.Rows[0][38]);
                m.Aguacate = Escape.getBoolean(dt.Rows[0][39]);
                m.Aceituna = Escape.getBoolean(dt.Rows[0][40]);
                m.Avellana = Escape.getBoolean(dt.Rows[0][41]);
                m.Coco = Escape.getBoolean(dt.Rows[0][42]);
                m.Nuez = Escape.getBoolean(dt.Rows[0][43]);
                m.Cacao = Escape.getBoolean(dt.Rows[0][44]);
                m.Durazno = Escape.getBoolean(dt.Rows[0][45]);
                m.Lactosa = Escape.getBoolean(dt.Rows[0][46]);
                m.Num_lactosa = Escape.getInt(dt.Rows[0][47]);
                m.Num_verd = Escape.getInt(dt.Rows[0][48]);
                m.Esparrago = Escape.getBoolean(dt.Rows[0][49]);
                m.Espinaca = Escape.getBoolean(dt.Rows[0][50]);
                m.Acelga = Escape.getBoolean(dt.Rows[0][51]);
                m.Cardo = Escape.getBoolean(dt.Rows[0][52]);
                m.Borraja = Escape.getBoolean(dt.Rows[0][53]);
                m.Lechuga = Escape.getBoolean(dt.Rows[0][54]);
                m.Pepinillo = Escape.getBoolean(dt.Rows[0][55]);
                m.Tomate = Escape.getBoolean(dt.Rows[0][56]);
                m.Pimiento = Escape.getBoolean(dt.Rows[0][57]);
                m.Berenjena = Escape.getBoolean(dt.Rows[0][58]);
                m.Calabacin = Escape.getBoolean(dt.Rows[0][59]);
                m.Alcachofa = Escape.getBoolean(dt.Rows[0][60]);
                m.Puerro = Escape.getBoolean(dt.Rows[0][61]);
                m.Ajo = Escape.getBoolean(dt.Rows[0][62]);
                m.Cebolla = Escape.getBoolean(dt.Rows[0][63]);
                m.Nabo = Escape.getBoolean(dt.Rows[0][64]);
                m.Patata = Escape.getBoolean(dt.Rows[0][65]);
                m.Rabanos = Escape.getBoolean(dt.Rows[0][66]);
                m.Remolacha = Escape.getBoolean(dt.Rows[0][67]);
                m.Zanahoria = Escape.getBoolean(dt.Rows[0][68]);
                m.Judias = Escape.getBoolean(dt.Rows[0][69]);
                m.Guisantes = Escape.getBoolean(dt.Rows[0][70]);
                m.Lentejas = Escape.getBoolean(dt.Rows[0][71]);
                m.Alubias = Escape.getBoolean(dt.Rows[0][72]);
                m.Repollo = Escape.getBoolean(dt.Rows[0][73]);
                m.Brecol = Escape.getBoolean(dt.Rows[0][74]);
                m.Coles = Escape.getBoolean(dt.Rows[0][75]);
                m.Coliflor = Escape.getBoolean(dt.Rows[0][76]);
                m.Champinnon = Escape.getBoolean(dt.Rows[0][77]);
                m.Setas = Escape.getBoolean(dt.Rows[0][78]);
                m.Huevos = Escape.getBoolean(dt.Rows[0][79]);
                m.Pan = Escape.getBoolean(dt.Rows[0][80]);
                m.Arroz = Escape.getBoolean(dt.Rows[0][81]);
                m.Pasta = Escape.getBoolean(dt.Rows[0][82]);
                m.Tipo = Escape.getBoolean(dt.Rows[0][83]);
                m.Pescado = Escape.getBoolean(dt.Rows[0][84]);
                m.Carne = Escape.getBoolean(dt.Rows[0][85]);
                m.Pollo = Escape.getBoolean(dt.Rows[0][86]);
                m.Estilo = Escape.getInt(dt.Rows[0][87]);
                m.Presupuesto = Escape.getInt(dt.Rows[0][88]);
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
        return m;
    }

    public void Actualizar()
    {
        OdbcCommand c = null;
        OdbcTransaction t = null;

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

                c.CommandText = "UPDATE VN_MODELLING SET ";
                if (this.Usuario != null)
                {
                    c.CommandText += "ID_USER = " + this.Usuario.Id + ", ";
                }
                else
                {
                    c.CommandText += "ID_USER = NULL, ";
                }
                c.CommandText += "SEX = " + this.Genero + ", ";
                if (this.Edad != null)
                {
                    c.CommandText += "ID_AGE = " + this.Edad.Id + ", ";
                }
                else
                {
                    c.CommandText += "ID_AGE = NULL, ";
                }
                c.CommandText += "HEIGHT = '" + Escape.MySql(this.Estatura) + "', " +
                                    "WEIGHT = '" + Escape.MySql(this.Peso) + "', " +
                                    "NUM_MEALS = " + this.Num_comidas + ", " +
                                    "RELIGION = '" + this.Religion + "', ";
                if (this.Pais != null)
                {
                    c.CommandText += "ID_COUNTRY = " + this.Pais.Id + ", ";
                }
                else
                {
                    c.CommandText += "ID_COUNTRY = NULL, ";
                }
                c.CommandText += "DIABETES = " + this.Diabetes + ", " +
                                    "CHOLESTEROL = " + this.Colesterol + ", " +
                                    "HEPATIC = " + this.Hepatica + ", " +
                                    "RENAL = " + this.Renal + ", " +
                                    "PANCREAS = " + this.Pancreas + ", " +
                                    "BILE = " + this.Bilis + ", " +
                                    "ULCER = " + this.Ulcera + ", " +
                                    "COLITIS = " + this.Colitis + ", " +
                                    "COLON = " + this.Colon + ", " +
                                    "INTESTINE = " + this.Intestino + ", " +
                                    "NUM_FRUIT = " + this.Num_fruta + ", " +
                                    "BANANA = " + this.Platano + ", " +
                                    "CHERRY = " + this.Cereza + ", " +
                                    "PLUM = " + this.Ciruela + ", " +
                                    "GUAVA = " + this.Guayaba + ", " +
                                    "SOURSOP = " + this.Guanabana + ", " +
                                    "FIG = " + this.Higo + ", " +
                                    "PEAR = " + this.Pera + ", " +
                                    "APRICOT = " + this.Albaricoque + ", " +
                                    "LEMON = " + this.Limon + ", " +
                                    "ORANGE = " + this.Naranja + ", " +
                                    "PINEAPPLE = " + this.Pinna + ", " +
                                    "TAMARIND = " + this.Tamarindo + ", " +
                                    "GRAPEFRUIT = " + this.Toronja + ", " +
                                    "GRAPE = " + this.Uva + ", " +
                                    "APPLE = " + this.Manzana + ", " +
                                    "PEACH = " + this.Melocoton + ", " +
                                    "STRAWBERRY = " + this.Fresa + ", " +
                                    "TANGERINE = " + this.Mandarina + ", " +
                                    "LIME = " + this.Lima + ", " +
                                    "AVOCADO = " + this.Aguacate + ", " +
                                    "OLIVE = " + this.Aceituna + ", " +
                                    "HAZELNUT = " + this.Avellana + ", " +
                                    "COCONUT = " + this.Coco + ", " +
                                    "NUT = " + this.Nuez + ", " +
                                    "COCOA = " + this.Cacao + ", " +
                                    "SMALLPEACH = " + this.Durazno + ", " +
                                    "LACTOSE = " + this.Lactosa + ", " +
                                    "NUM_LACTOSE = " + this.Num_lactosa + ", " +
                                    "NUM_GREEN = " + this.Num_verd + ", " +
                                    "ASPARAGUS = " + this.Esparrago + ", " +
                                    "SPINACH = " + this.Espinaca + ", " +
                                    "CHARD = " + this.Acelga + ", " +
                                    "THISTLE = " + this.Cardo + ", " +
                                    "BORAGE = " + this.Borraja + ", " +
                                    "LETTUCE = " + this.Lechuga + ", " +
                                    "PICKLE = " + this.Pepinillo + ", " +
                                    "TOMATO = " + this.Tomate + ", " +
                                    "PEPPER = " + this.Pimiento + ", " +
                                    "EGGPLANT = " + this.Berenjena + ", " +
                                    "ZUCCHINI = " + this.Calabacin + ", " +
                                    "ARTICHOKE = " + this.Alcachofa + ", " +
                                    "LEEK = " + this.Puerro + ", " +
                                    "GARLIC = " + this.Ajo + ", " +
                                    "ONION = " + this.Cebolla + ", " +
                                    "TURNIP = " + this.Nabo + ", " +
                                    "POTATO = " + this.Patata + ", " +
                                    "RADISHES = " + this.Rabanos + ", " +
                                    "BEET = " + this.Remolacha + ", " +
                                    "CARROT = " + this.Zanahoria + ", " +
                                    "GREENBEANS = " + this.Judias + ", " +
                                    "PEAS = " + this.Guisantes + ", " +
                                    "LENTILS = " + this.Lentejas + ", " +
                                    "BEANS = " + this.Alubias + ", " +
                                    "CABBAGE = " + this.Repollo + ", " +
                                    "BRECOL = " + this.Brecol + ", " +
                                    "BRUSSELSSPROUTS = " + this.Coles + ", " +
                                    "CAULIFLOWER = " + this.Coliflor + ", " +
                                    "BUTTONMUSHROOM = " + this.Champinnon + ", " +
                                    "MUSHROOMS = " + this.Setas + ", " +
                                    "EGGS = " + this.Huevos + ", " +
                                    "BREAD = " + this.Pan + ", " +
                                    "RICE = " + this.Arroz + ", " +
                                    "PASTA = " + this.Pasta + ", " +
                                    "TYPE_EATER = " + this.Tipo + ", " +
                                    "FISH = " + this.Pescado + ", " +
                                    "MEAT = " + this.Carne + ", " +
                                    "CHICKEN = " + this.Pollo + ", " +
                                    "STYLE = " + this.Estilo + ", " +
                                    "BUDGET = " + this.Presupuesto + " " +
                                    "WHERE VN_MODELLING.ID_MODELLING = " + this.Id;
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

                    query = "SELECT COUNT(VN_MODELLING.ID_MODELLING) " +
                            "FROM VN_MODELLING";
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

    #region "IEquatable(Of Modelado) Members"
    public bool Equals(Modelado other)
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
        if ((obj is Modelado))
        {
            return Equals((Modelado)obj);
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

    public static bool operator ==(Modelado u1, Modelado u2)
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

    public static bool operator !=(Modelado u1, Modelado u2)
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

    #region "IComparable(Of Modelado) Members"
    public int CompareTo(Modelado other)
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

    public Modelado()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}