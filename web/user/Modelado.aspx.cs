using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Modelado : System.Web.UI.Page
{
    protected static List<Pais> lp = null;
    protected static List<Edad> led = null;

    protected static Modelado m = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Common.Usuario == null)
        {
            Common.SessionAbandon();
            return;
        }
        if ((Common.Usuario.Login == string.Empty) || (Usuario.User.Contains(Common.Usuario) == false))
        {
            Common.SessionAbandon();
            return;
        }
        if (Common.Usuario.Acceso == "DESHABILITADO")
        {
            Response.Redirect("CuestionarioA.aspx");
        }
        try
        {
            m = Common.Modelado;
            Pais[] ap = Pais.Paises;
            if (ap != null)
            {
                lp = ap.ToList<Pais>();
            }
            Edad[] aed = Edad.Edades;
            if (aed != null)
            {
                led = aed.ToList<Edad>();
            }
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }
    }
    protected void Actualizar_Click(object sender, EventArgs e)
    {
        try
        {
            if (HttpContext.Current.Request["gen"] == "1")
            {
                m.Genero = true;
            }
            else
            {
                m.Genero = false;
            }

            int id_edad = Escape.getInt(HttpContext.Current.Request["id_edad"]);
            m.Edad = Edad.getById(id_edad);
            m.Estatura = Escape.getString(HttpContext.Current.Request["estatura"]);
            m.Peso = Escape.getString(HttpContext.Current.Request["peso"]);
            m.Num_comidas = Escape.getInt(HttpContext.Current.Request["id_num_comidas"]);
            m.Religion = HttpContext.Current.Request["religion"];
            int id_pais = Escape.getInt(HttpContext.Current.Request["id_pais"]);
            m.Pais = Pais.getById(id_pais);
            if (HttpContext.Current.Request["diabetes"] == "on")
            {
                m.Diabetes = true;
            }
            else
            {
                m.Diabetes = false;
            }
            if (HttpContext.Current.Request["colesterol"] == "on")
            {
                m.Colesterol = true;
            }
            else
            {
                m.Colesterol = false;
            }
            if (HttpContext.Current.Request["hepatica"] == "on")
            {
                m.Hepatica = true;
            }
            else
            {
                m.Hepatica = false;
            }
            if (HttpContext.Current.Request["renal"] == "on")
            {
                m.Renal = true;
            }
            else
            {
                m.Renal = false;
            }
            if (HttpContext.Current.Request["pancreas"] == "on")
            {
                m.Pancreas = true;
            }
            else
            {
                m.Pancreas = false;
            }
            if (HttpContext.Current.Request["bilis"] == "on")
            {
                m.Bilis = true;
            }
            else
            {
                m.Bilis = false;
            }
            if (HttpContext.Current.Request["ulcera"] == "on")
            {
                m.Ulcera = true;
            }
            else
            {
                m.Ulcera = false;
            }
            if (HttpContext.Current.Request["colitis"] == "on")
            {
                m.Colitis = true;
            }
            else
            {
                m.Colitis = false;
            }
            if (HttpContext.Current.Request["colon"] == "on")
            {
                m.Colon = true;
            }
            else
            {
                m.Colon = false;
            }
            if (HttpContext.Current.Request["intestino"] == "on")
            {
                m.Intestino = true;
            }
            else
            {
                m.Intestino = false;
            }

            m.Num_fruta = Escape.getInt(HttpContext.Current.Request["num_fruta"]);
            if (m.Num_fruta > 1)
            {
                if (HttpContext.Current.Request["platano"] == "on")
                {
                    m.Platano = true;
                }
                else
                {
                    m.Platano = false;
                }
                if (HttpContext.Current.Request["cereza"] == "on")
                {
                    m.Cereza = true;
                }
                else
                {
                    m.Cereza = false;
                }
                if (HttpContext.Current.Request["ciruela"] == "on")
                {
                    m.Ciruela = true;
                }
                else
                {
                    m.Ciruela = false;
                }
                if (HttpContext.Current.Request["guayaba"] == "on")
                {
                    m.Guayaba = true;
                }
                else
                {
                    m.Guayaba = false;
                }
                if (HttpContext.Current.Request["guanabana"] == "on")
                {
                    m.Guanabana = true;
                }
                else
                {
                    m.Guanabana = false;
                }
                if (HttpContext.Current.Request["higo"] == "on")
                {
                    m.Higo = true;
                }
                else
                {
                    m.Higo = false;
                }
                if (HttpContext.Current.Request["pera"] == "on")
                {
                    m.Pera = true;
                }
                else
                {
                    m.Pera = false;
                }
                if (HttpContext.Current.Request["albaricoque"] == "on")
                {
                    m.Albaricoque = true;
                }
                else
                {
                    m.Albaricoque = false;
                }
                if (HttpContext.Current.Request["limon"] == "on")
                {
                    m.Limon = true;
                }
                else
                {
                    m.Limon = false;
                }
                if (HttpContext.Current.Request["naranja"] == "on")
                {
                    m.Naranja = true;
                }
                else
                {
                    m.Naranja = false;
                }
                if (HttpContext.Current.Request["pinna"] == "on")
                {
                    m.Pinna = true;
                }
                else
                {
                    m.Pinna = false;
                }
                if (HttpContext.Current.Request["tamarindo"] == "on")
                {
                    m.Tamarindo = true;
                }
                else
                {
                    m.Tamarindo = false;
                }
                if (HttpContext.Current.Request["toronja"] == "on")
                {
                    m.Toronja = true;
                }
                else
                {
                    m.Toronja = false;
                }
                if (HttpContext.Current.Request["uva"] == "on")
                {
                    m.Uva = true;
                }
                else
                {
                    m.Uva = false;
                }
                if (HttpContext.Current.Request["manzana"] == "on")
                {
                    m.Manzana = true;
                }
                else
                {
                    m.Manzana = false;
                }
                if (HttpContext.Current.Request["melocoton"] == "on")
                {
                    m.Melocoton = true;
                }
                else
                {
                    m.Melocoton = false;
                }
                if (HttpContext.Current.Request["fresa"] == "on")
                {
                    m.Fresa = true;
                }
                else
                {
                    m.Fresa = false;
                }
                if (HttpContext.Current.Request["mandarina"] == "on")
                {
                    m.Mandarina = true;
                }
                else
                {
                    m.Mandarina = false;
                }
                if (HttpContext.Current.Request["lima"] == "on")
                {
                    m.Lima = true;
                }
                else
                {
                    m.Lima = false;
                }
                if (HttpContext.Current.Request["aguacate"] == "on")
                {
                    m.Aguacate = true;
                }
                else
                {
                    m.Aguacate = false;
                }
                if (HttpContext.Current.Request["aceituna"] == "on")
                {
                    m.Aceituna = true;
                }
                else
                {
                    m.Aceituna = false;
                }
                if (HttpContext.Current.Request["avellana"] == "on")
                {
                    m.Avellana = true;
                }
                else
                {
                    m.Avellana = false;
                }
                if (HttpContext.Current.Request["coco"] == "on")
                {
                    m.Coco = true;
                }
                else
                {
                    m.Coco = false;
                }
                if (HttpContext.Current.Request["nuez"] == "on")
                {
                    m.Nuez = true;
                }
                else
                {
                    m.Nuez = false;
                }
                if (HttpContext.Current.Request["cacao"] == "on")
                {
                    m.Cacao = true;
                }
                else
                {
                    m.Cacao = false;
                }
                if (HttpContext.Current.Request["durazno"] == "on")
                {
                    m.Durazno = true;
                }
                else
                {
                    m.Durazno = false;
                }
            }
            else
            {
                m.Platano = false;
                m.Cereza = false;
                m.Ciruela = false;
                m.Guayaba = false;
                m.Guanabana = false;
                m.Higo = false;
                m.Pera = false;
                m.Albaricoque = false;
                m.Limon = false;
                m.Naranja = false;
                m.Pinna = false;
                m.Tamarindo = false;
                m.Toronja = false;
                m.Uva = false;
                m.Manzana = false;
                m.Melocoton = false;
                m.Fresa = false;
                m.Mandarina = false;
                m.Lima = false;
                m.Aguacate = false;
                m.Aceituna = false;
                m.Avellana = false;
                m.Coco = false;
                m.Nuez = false;
                m.Cacao = false;
                m.Durazno = false;
            }
            if (HttpContext.Current.Request["lactosa"] == "lactosa_no")
            {
                m.Lactosa = true;
            }
            else
            {
                m.Lactosa = false;
            }
            if (m.Lactosa == false)
            {
                m.Num_lactosa = Escape.getInt(HttpContext.Current.Request["num_lactosa"]);
            }
            else
            {
                m.Num_lactosa = 1;
            }
            m.Num_verd = Escape.getInt(HttpContext.Current.Request["num_verd"]);
            if (m.Num_verd > 1)
            {
                if (HttpContext.Current.Request["esparrago"] == "on")
                {
                    m.Esparrago = true;
                }
                else
                {
                    m.Esparrago = false;
                }
                if (HttpContext.Current.Request["espinaca"] == "on")
                {
                    m.Espinaca = true;
                }
                else
                {
                    m.Espinaca = false;
                }
                if (HttpContext.Current.Request["acelga"] == "on")
                {
                    m.Acelga = true;
                }
                else
                {
                    m.Acelga = false;
                }
                if (HttpContext.Current.Request["cardo"] == "on")
                {
                    m.Cardo = true;
                }
                else
                {
                    m.Cardo = false;
                }
                if (HttpContext.Current.Request["borraja"] == "on")
                {
                    m.Borraja = true;
                }
                else
                {
                    m.Borraja = false;
                }
                if (HttpContext.Current.Request["lechuga"] == "on")
                {
                    m.Lechuga = true;
                }
                else
                {
                    m.Lechuga = false;
                }
                if (HttpContext.Current.Request["pepinillo"] == "on")
                {
                    m.Pepinillo = true;
                }
                else
                {
                    m.Pepinillo = false;
                }
                if (HttpContext.Current.Request["tomate"] == "on")
                {
                    m.Tomate = true;
                }
                else
                {
                    m.Tomate = false;
                }
                if (HttpContext.Current.Request["pimiento"] == "on")
                {
                    m.Pimiento = true;
                }
                else
                {
                    m.Pimiento = false;
                }
                if (HttpContext.Current.Request["berenjena"] == "on")
                {
                    m.Berenjena = true;
                }
                else
                {
                    m.Berenjena = false;
                }
                if (HttpContext.Current.Request["calabacin"] == "on")
                {
                    m.Calabacin = true;
                }
                else
                {
                    m.Calabacin = false;
                }
                if (HttpContext.Current.Request["alcachofa"] == "on")
                {
                    m.Alcachofa = true;
                }
                else
                {
                    m.Alcachofa = false;
                }
                if (HttpContext.Current.Request["puerro"] == "on")
                {
                    m.Puerro = true;
                }
                else
                {
                    m.Puerro = false;
                }
                if (HttpContext.Current.Request["ajo"] == "on")
                {
                    m.Ajo = true;
                }
                else
                {
                    m.Ajo = false;
                }
                if (HttpContext.Current.Request["cebolla"] == "on")
                {
                    m.Cebolla = true;
                }
                else
                {
                    m.Cebolla = false;
                }
                if (HttpContext.Current.Request["nabo"] == "on")
                {
                    m.Nabo = true;
                }
                else
                {
                    m.Nabo = false;
                }
                if (HttpContext.Current.Request["patata"] == "on")
                {
                    m.Patata = true;
                }
                else
                {
                    m.Patata = false;
                }
                if (HttpContext.Current.Request["rabanos"] == "on")
                {
                    m.Rabanos = true;
                }
                else
                {
                    m.Rabanos = false;
                }
                if (HttpContext.Current.Request["remolacha"] == "on")
                {
                    m.Remolacha = true;
                }
                else
                {
                    m.Remolacha = false;
                }
                if (HttpContext.Current.Request["zanahoria"] == "on")
                {
                    m.Zanahoria = true;
                }
                else
                {
                    m.Zanahoria = false;
                }
                if (HttpContext.Current.Request["judias"] == "on")
                {
                    m.Judias = true;
                }
                else
                {
                    m.Judias = false;
                }
                if (HttpContext.Current.Request["guisantes"] == "on")
                {
                    m.Guisantes = true;
                }
                else
                {
                    m.Guisantes = false;
                }
                if (HttpContext.Current.Request["lentejas"] == "on")
                {
                    m.Lentejas = true;
                }
                else
                {
                    m.Lentejas = false;
                }
                if (HttpContext.Current.Request["alubias"] == "on")
                {
                    m.Alubias = true;
                }
                else
                {
                    m.Alubias = false;
                }
                if (HttpContext.Current.Request["repollo"] == "on")
                {
                    m.Repollo = true;
                }
                else
                {
                    m.Repollo = false;
                }
                if (HttpContext.Current.Request["brecol"] == "on")
                {
                    m.Brecol = true;
                }
                else
                {
                    m.Brecol = false;
                }
                if (HttpContext.Current.Request["coles"] == "on")
                {
                    m.Coles = true;
                }
                else
                {
                    m.Coles = false;
                }
                if (HttpContext.Current.Request["coliflor"] == "on")
                {
                    m.Coliflor = true;
                }
                else
                {
                    m.Coliflor = false;
                }
                if (HttpContext.Current.Request["champinnon"] == "on")
                {
                    m.Champinnon = true;
                }
                else
                {
                    m.Champinnon = false;
                }
                if (HttpContext.Current.Request["setas"] == "on")
                {
                    m.Setas = true;
                }
                else
                {
                    m.Setas = false;
                }
            }
            else
            {
                m.Esparrago = false;
                m.Espinaca = false;
                m.Acelga = false;
                m.Cardo = false;
                m.Borraja = false;
                m.Lechuga = false;
                m.Pepinillo = false;
                m.Tomate = false;
                m.Pimiento = false;
                m.Berenjena = false;
                m.Alcachofa = false;
                m.Puerro = false;
                m.Ajo = false;
                m.Cebolla = false;
                m.Nabo = false;
                m.Patata = false;
                m.Rabanos = false;
                m.Remolacha = false;
                m.Zanahoria = false;
                m.Judias = false;
                m.Guisantes = false;
                m.Lentejas = false;
                m.Repollo = false;
                m.Brecol = false;
                m.Coles = false;
                m.Coliflor = false;
                m.Champinnon = false;
                m.Setas = false;
            }
            if (HttpContext.Current.Request["huevos"] == "on")
            {
                m.Huevos = true;
            }
            else
            {
                m.Huevos = false;
            }
            if (HttpContext.Current.Request["pan"] == "on")
            {
                m.Pan = true;
            }
            else
            {
                m.Pan = false;
            }
            if (HttpContext.Current.Request["arroz"] == "on")
            {
                m.Arroz = true;
            }
            else
            {
                m.Arroz = false;
            }
            if (HttpContext.Current.Request["pasta"] == "on")
            {
                m.Pasta = true;
            }
            else
            {
                m.Pasta = false;
            }
            if (HttpContext.Current.Request["tipo"] == "1")
            {
                m.Tipo = true;
            }
            else
            {
                m.Tipo = false;
            }
            if (m.Tipo == false)
            {
                if (HttpContext.Current.Request["pescado"] == "on")
                {
                    m.Pescado = true;
                }
                else
                {
                    m.Pescado = false;
                }
                if (HttpContext.Current.Request["carne"] == "on")
                {
                    m.Carne = true;
                }
                else
                {
                    m.Carne = false;
                }
                if (HttpContext.Current.Request["pollo"] == "on")
                {
                    m.Pollo = true;
                }
                else
                {
                    m.Pollo = false;
                }
            }
            m.Estilo = Escape.getInt(HttpContext.Current.Request["estilo"]);
            m.Presupuesto = Escape.getInt(HttpContext.Current.Request["presupuesto"]);

            m.Actualizar();

            Common.Modelado = m;

            MsgBox.Show("The user modelling has been updated");
        }
        catch (Exception ex)
        {
            MsgBox.Show(ex.Message);
        }
    }
}
