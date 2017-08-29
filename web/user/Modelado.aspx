<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modelado.aspx.cs" Inherits="_Modelado" %>

<%@ Register Src="~/Menu.ascx" TagPrefix="cc" TagName="Menu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <title>UAM</title>
    <link href="../css/vn_sistema.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #title h1
        {
            width: 1000px;
            height: 100px;
            background: url(../css/img/cabecara.png) left top no-repeat;
            text-indent: -5000px;
        }
        .parrafo_001
        {
            color: #008cdb;
            font-size: 10px;
            text-align: center;
            padding-right: 200px;
        }
        #location h2
        {
            text-align: left;
            scrollbar-arrow-color: #333333;
            scrollbar-3dlight-color: #999999;
            scrollbar-darkshadow-color: #000000;
            scrollbar-face-color: #f0f0ef;
            scrollbar-highlight-color: #bebebe;
            scrollbar-shadow-color: #212121;
            scrollbar-track-color: #f0f0ef;
            font-family: Helvetica, Arial, sans-serif;
            color: #333333;
            font-size: 14px;
            background: #fff;
        }
    </style>

    <script type="text/javascript">
        function toggleLactosa() {
            var val = document.getElementById('lactosa_no');
            if (val.checked == true) {
                document.getElementById('tr_lactosa_si').style.display = 'none';
            }
            else {
                document.getElementById('tr_lactosa_si').style.display = 'block';
            }
        }
        function toggleFruta() {
            var val = document.getElementById('num_fruta_2');
            if (val.checked == true) {
                document.getElementById('tr_fruta_si').style.display = 'none';
            }
            else {
                document.getElementById('tr_fruta_si').style.display = 'block';
            }
        }
        function toggleVerdura() {
            var val = document.getElementById('num_verd_2');
            if (val.checked == true) {
                document.getElementById('tr_verd_si').style.display = 'none';
            }
            else {
                document.getElementById('tr_verd_si').style.display = 'block';
            }
        }
        function toggleCarne() {
            var val = document.getElementById('tipo_carne');
            if (val.checked == true) {
                document.getElementById('tr_tipo_carne').style.display = 'block';
            }
            else {
                document.getElementById('tr_tipo_carne').style.display = 'none';
            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="title">
        <h1 class="parrafo_001">
            UAM</h1>
    </div>
    <div id="location">
        <h2>
            GOOD EATING</h2>
        <p>
        </p>
    </div>
    <cc:Menu ID="Menu1" runat="server" />
    <fieldset>
        <table>
            <tr>
                <td width="1000px">
                    <fieldset>
                        <legend class="text">USER MODELLING</legend>
                        <table>
                            <tr>
                                <td valign="top">
                                    <table>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">1. Sex (*)</legend>
                                                    <% if (m.Genero == true)
                                                       { %>
                                                    <input type="radio" name="gen" id="gen_mas" value="1" checked="checked" />Male
                                                    <input type="radio" name="gen" id="gen_fem" value="2" />Female
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="radio" name="gen" id="gen_mas" value="1" />Male
                                                    <input type="radio" name="gen" id="gen_fem" value="2" checked="checked" />Female
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">2. Age (*)</legend>
                                                    <select name="id_edad" id="id_edad">
                                                        <option value="0">Select</option>
                                                        <% foreach (Edad ed in led)
                                                           { %>
                                                        <% if ((m.Edad != null) && (m.Edad.Id == ed.Id))
                                                           { %>
                                                        <option value="<%= ed.Id %>" selected="selected">
                                                            <%= ed.Valor%></option>
                                                        <% continue; %>
                                                        <% } %>
                                                        <option value="<%= ed.Id %>">
                                                            <%= ed.Valor%></option>
                                                        <% } %>
                                                    </select>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">3. Height (*)</legend>
                                                    <input type="text" name="estatura" id="estatura" value="<%= m.Estatura %>" />&nbsp;(m.)
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">4. Weight (*)</legend>
                                                    <input type="text" name="peso" id="peso" value="<%= m.Peso %>" />&nbsp;(kg.)
                                                </fieldset>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td valign="top">
                                    <table>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">5. Number of meals per day (*)</legend>
                                                    <select name="id_num_comidas" id="id_num_comidas">
                                                        <option value="0">Select</option>
                                                        <% for (int i = 1; i < 5; i++)
                                                           { %>
                                                        <% if (m.Num_comidas == i)
                                                           { %>
                                                        <option value="<%= i %>" selected="selected">
                                                            <%= i%></option>
                                                        <% continue; %>
                                                        <% } %>
                                                        <option value="<%= i %>">
                                                            <%= i %></option>
                                                        <% } %>
                                                    </select>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">6. Religion (*)</legend>
                                                    <% if (m.Religion == "cristiano")
                                                       { %>
                                                    <input type="radio" name="religion" id="cristiano" value="cristiano" checked="checked" />Christian<br />
                                                    <input type="radio" name="religion" id="musulman" value="musulman" />Muslim<br />
                                                    <input type="radio" name="religion" id="judio" value="judio" />Jew<br />
                                                    <input type="radio" name="religion" id="no_procede" value="no_procede" />Not applicable
                                                    <% } %>
                                                    <% else if (m.Religion == "musulman")
                                                        { %>
                                                    <input type="radio" name="religion" id="cristiano" value="cristiano" />Christian<br />
                                                    <input type="radio" name="religion" id="musulman" value="musulman" checked="checked" />Muslim<br />
                                                    <input type="radio" name="religion" id="judio" value="judio" />Jew<br />
                                                    <input type="radio" name="religion" id="no_procede" value="no_procede" />Not applicable
                                                    <% } %>
                                                    <% else if (m.Religion == "judio")
                                                        { %>
                                                    <input type="radio" name="religion" id="cristiano" value="cristiano" />Christian<br />
                                                    <input type="radio" name="religion" id="musulman" value="musulman" />Muslim<br />
                                                    <input type="radio" name="religion" id="judio" value="judio" checked="checked" />Jew<br />
                                                    <input type="radio" name="religion" id="no_procede" value="no_procede" />Not applicable
                                                    <% } %>
                                                    <% else if (m.Religion == "no_procede")
                                                        { %>
                                                    <input type="radio" name="religion" id="cristiano" value="cristiano" />Christian<br />
                                                    <input type="radio" name="religion" id="musulman" value="musulman" />Muslim<br />
                                                    <input type="radio" name="religion" id="judio" value="judio" />Jew<br />
                                                    <input type="radio" name="religion" id="no_procede" value="no_procede" checked="checked" />Not applicable
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="radio" name="religion" id="cristiano" value="cristiano" />Christian<br />
                                                    <input type="radio" name="religion" id="musulman" value="musulman" />Muslim<br />
                                                    <input type="radio" name="religion" id="judio" value="judio" />Jew<br />
                                                    <input type="radio" name="religion" id="no_procede" value="no_procede" />Not applicable
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">7. Country (*)</legend>
                                                    <select name="id_pais" id="id_pais">
                                                        <option value="0">Select</option>
                                                        <% foreach (Pais p in lp)
                                                           { %>
                                                        <% if ((m.Pais != null) && (m.Pais.Id == p.Id))
                                                           { %>
                                                        <option value="<%= p.Id %>" selected="selected">
                                                            <%= p.Nombre %></option>
                                                        <% continue; %>
                                                        <% } %>
                                                        <option value="<%= p.Id %>">
                                                            <%= p.Nombre%></option>
                                                        <% } %>
                                                    </select>
                                                </fieldset>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" colspan="4">
                                    <table>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">8. Check the box if you suffer of any of these illnesses</legend>
                                                    <%if (m.Diabetes == true)
                                                      { %>
                                                    <input type="checkbox" name="diabetes" id="diabetes" checked="checked" />Diabetes<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="diabetes" id="diabetes" />Diabetes<br />
                                                    <% } %>
                                                    <% if (m.Colesterol == true)
                                                       { %>
                                                    <input type="checkbox" name="colesterol" id="colesterol" checked="checked" />Cholesterol<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="colesterol" id="colesterol" />Cholesterol<br />
                                                    <% } %>
                                                    <% if (m.Hepatica == true)
                                                       { %>
                                                    <input type="checkbox" name="hepatica" id="hepatica" checked="checked" />Liver failure<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="hepatica" id="hepatica" />Liver failure<br />
                                                    <% } %>
                                                    <% if (m.Renal == true)
                                                       { %>
                                                    <input type="checkbox" name="renal" id="renal" checked="checked" />Renal insufficiency<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="renal" id="renal" />Renal insufficiency<br />
                                                    <% } %>
                                                    <% if (m.Pancreas == true)
                                                       { %>
                                                    <input type="checkbox" name="pancreas" id="pancreas" checked="checked" />Pancreatic diseases<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="pancreas" id="pancreas" />Pancreatic diseases<br />
                                                    <% } %>
                                                    <% if (m.Bilis == true)
                                                       { %>
                                                    <input type="checkbox" name="bilis" id="bilis" checked="checked" />Problems in the gallbladder<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="bilis" id="bilis" />Problems in the gallbladder<br />
                                                    <% } %>
                                                    <% if (m.Ulcera == true)
                                                       { %>
                                                    <input type="checkbox" name="ulcera" id="ulcera" checked="checked" />Ulcer<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="ulcera" id="ulcera" />Ulcer<br />
                                                    <% } %>
                                                    <% if (m.Colitis == true)
                                                       { %>
                                                    <input type="checkbox" name="colitis" id="colitis" checked="checked" />Ulcerative colitis<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="colitis" id="colitis" />Ulcerative colitis<br />
                                                    <% } %>
                                                    <% if (m.Colon == true)
                                                       { %>
                                                    <input type="checkbox" name="colon" id="colon" checked="checked" />Irritable colon<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="colon" id="colon" />Irritable colon<br />
                                                    <% } %>
                                                    <% if (m.Intestino == true)
                                                       { %>
                                                    <input type="checkbox" name="intestino" id="intestino" checked="checked" />Inflammation of the intestines
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="intestino" id="intestino" />Inflammation of the intestines
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" colspan="4">
                                    <table>
                                        <tr>
                                            <td colspan="4" align="left">
                                                <fieldset>
                                                    <legend class="text">9. Do you eat fruit?
                                                        (*)</legend>
                                                    <% if (m.Num_fruta == 1)
                                                       { %>
                                                    <input type="radio" name="num_fruta" id="num_fruta_1" value="1" onclick="toggleFruta()"
                                                        checked="checked" />No
                                                    <input type="radio" name="num_fruta" id="num_fruta_2" value="2" onclick="toggleFruta()" />Yes
                                                    <% } %>
                                                    <% else if (m.Num_fruta == 2)
                                                       { %>
                                                    <input type="radio" name="num_fruta" id="num_fruta_1" value="1" onclick="toggleFruta()" />No
                                                    <input type="radio" name="num_fruta" id="num_fruta_2" value="2" onclick="toggleFruta()"
                                                        checked="checked" />Yes
                                                    <% }
                                                       else
                                                       { %>
                                                    <input type="radio" name="num_fruta" id="Radio1" value="1" onclick="toggleFruta()" />No
                                                    <input type="radio" name="num_fruta" id="Radio2" value="2" onclick="toggleFruta()" />Yes
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <% if (m.Num_fruta <= 1)
                                           { %>
                                        <tr id="tr_fruta_si" style="display: none;">
                                            <% } %>
                                            <% else
                                                { %>
                                            <tr id="tr_fruta_si" style="display: block;">
                                                <% } %>
                                                <td valign="top" colspan="4">
                                                    <fieldset>
                                                        <legend class="text">Check the fruit(s) you like</legend>
                                                        <table>
                                                            <tr>
                                                                <td valign="top">
                                                                    <fieldset style="width: 140px;">
                                                                        <legend class="text">Sweet</legend>
                                                                        <%if (m.Platano == true)
                                                                          { %>
                                                                        <input type="checkbox" name="platano" id="platano" checked="checked" />Banana<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="platano" id="platano" />Banana<br />
                                                                        <% } %>
                                                                        <% if (m.Cereza == true)
                                                                           { %>
                                                                        <input type="checkbox" name="cereza" id="cereza" checked="checked" />Cherry<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="cereza" id="cereza" />Cherry<br />
                                                                        <% } %>
                                                                        <% if (m.Ciruela == true)
                                                                           { %>
                                                                        <input type="checkbox" name="ciruela" id="ciruela" checked="checked" />Plum<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="ciruela" id="ciruela" />Plum<br />
                                                                        <% } %>
                                                                        <% if (m.Guayaba == true)
                                                                           { %>
                                                                        <input type="checkbox" name="guayaba" id="guayaba" checked="checked" />Guava<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="guayaba" id="guayaba" />Guava<br />
                                                                        <% } %>
                                                                        <% if (m.Guanabana == true)
                                                                           { %>
                                                                        <input type="checkbox" name="guanabana" id="guanabana" checked="checked" />Soursop<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="guanabana" id="guanabana" />Soursop<br />
                                                                        <% } %>
                                                                        <% if (m.Higo == true)
                                                                           { %>
                                                                        <input type="checkbox" name="higo" id="higo" checked="checked" />Fig<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="higo" id="higo" />Fig<br />
                                                                        <% } %>
                                                                        <% if (m.Pera == true)
                                                                           { %>
                                                                        <input type="checkbox" name="pera" id="pera" checked="checked" />Pear<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="pera" id="pera" />Pear<br />
                                                                        <% } %>
                                                                        <% if (m.Albaricoque == true)
                                                                           { %>
                                                                        <input type="checkbox" name="albaricoque" id="albaricoque" checked="checked" />Apricot<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="albaricoque" id="albaricoque" />Apricot<br />
                                                                        <% } %>
                                                                    </fieldset>
                                                                </td>
                                                                <td valign="top">
                                                                    <fieldset style="width: 140px;">
                                                                        <legend class="text">Acid</legend>
                                                                        <% if (m.Limon == true)
                                                                           { %>
                                                                        <input type="checkbox" name="limon" id="limon" checked="checked" />Lemon<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="limon" id="limon" />Lemon<br />
                                                                        <% } %>
                                                                        <% if (m.Naranja == true)
                                                                           { %>
                                                                        <input type="checkbox" name="naranja" id="naranja" checked="checked" />Orange<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="naranja" id="naranja" />Orange<br />
                                                                        <% } %>
                                                                        <% if (m.Pinna == true)
                                                                           { %>
                                                                        <input type="checkbox" name="pinna" id="pinna" checked="checked" />Pineapple<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="pinna" id="pinna" />Pineapple<br />
                                                                        <% } %>
                                                                        <% if (m.Tamarindo == true)
                                                                           { %>
                                                                        <input type="checkbox" name="tamarindo" id="tamarindo" checked="checked" />Tamarind<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="tamarindo" id="tamarindo" />Tamarind<br />
                                                                        <% } %>
                                                                        <% if (m.Toronja == true)
                                                                           { %>
                                                                        <input type="checkbox" name="toronja" id="toronja" checked="checked" />Grapefruit<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="toronja" id="toronja" />Grapefruit<br />
                                                                        <% } %>
                                                                        <% if (m.Uva == true)
                                                                           { %>
                                                                        <input type="checkbox" name="uva" id="uva" checked="checked" />Grape<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="uva" id="uva" />Grape<br />
                                                                        <% } %>
                                                                        <% if (m.Manzana == true)
                                                                           { %>
                                                                        <input type="checkbox" name="manzana" id="manzana" checked="checked" />Apple<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="manzana" id="manzana" />Apple<br />
                                                                        <% } %>
                                                                    </fieldset>
                                                                </td>
                                                                <td valign="top">
                                                                    <fieldset style="width: 140px;">
                                                                        <legend class="text">Semi-acid</legend>
                                                                        <% if (m.Melocoton == true)
                                                                           { %>
                                                                        <input type="checkbox" name="melocoton" id="melocoton" checked="checked" />Peach<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="melocoton" id="melocoton" />Peach<br />
                                                                        <% } %>
                                                                        <% if (m.Fresa == true)
                                                                           { %>
                                                                        <input type="checkbox" name="fresa" id="fresa" checked="checked" />Strawberry<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="fresa" id="fresa" />Strawberry<br />
                                                                        <% } %>
                                                                        <% if (m.Mandarina == true)
                                                                           { %>
                                                                        <input type="checkbox" name="mandarina" id="mandarina" checked="checked" />Tangerine<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="mandarina" id="mandarina" />Tangerine<br />
                                                                        <% } %>
                                                                        <% if (m.Lima == true)
                                                                           {%>
                                                                        <input type="checkbox" name="lima" id="lima" checked="checked" />Lime<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="lima" id="lima" />Lime<br />
                                                                        <% } %>
                                                                    </fieldset>
                                                                </td>
                                                                <td valign="top">
                                                                    <fieldset style="width: 140px;">
                                                                        <legend class="text">Neutrals</legend>
                                                                        <% if (m.Aguacate == true)
                                                                           { %>
                                                                        <input type="checkbox" name="aguacate" id="aguacate" checked="checked" />Avocado<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="aguacate" id="aguacate" />Avocado<br />
                                                                        <% } %>
                                                                        <% if (m.Aceituna == true)
                                                                           { %>
                                                                        <input type="checkbox" name="aceituna" id="aceituna" checked="checked" />Olive<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="aceituna" id="aceituna" />Olive<br />
                                                                        <% } %>
                                                                        <% if (m.Avellana == true)
                                                                           { %>
                                                                        <input type="checkbox" name="avellana" id="avellana" checked="checked" />Hazelnut<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="avellana" id="avellana" />Hazelnut<br />
                                                                        <% } %>
                                                                        <% if (m.Coco == true)
                                                                           { %>
                                                                        <input type="checkbox" name="coco" id="coco" checked="checked" />Coconut<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="coco" id="coco" />Coconut<br />
                                                                        <% } %>
                                                                        <% if (m.Nuez == true)
                                                                           { %>
                                                                        <input type="checkbox" name="nuez" id="nuez" checked="checked" />Nut<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="nuez" id="nuez" />Nut<br />
                                                                        <% } %>
                                                                        <% if (m.Cacao == true)
                                                                           { %>
                                                                        <input type="checkbox" name="cacao" id="cacao" checked="checked" />Cocoa<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="cacao" id="cacao" />Cocoa<br />
                                                                        <% } %>
                                                                        <% if (m.Durazno == true)
                                                                           { %>
                                                                        <input type="checkbox" name="durazno" id="durazno" checked="checked" />Small peach<br />
                                                                        <% } %>
                                                                        <% else
                                                                            { %>
                                                                        <input type="checkbox" name="durazno" id="durazno" />Small peach<br />
                                                                        <% } %>
                                                                    </fieldset>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </fieldset>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="4" align="left">
                                                    <fieldset>
                                                        <legend class="text">10. Are you tolerant to lactose? (*)</legend>
                                                        <% if (m.Lactosa == true)
                                                           { %>
                                                        <input type="radio" name="lactosa" id="lactosa_no" value="lactosa_no" onclick="toggleLactosa()"
                                                            checked="checked" />No
                                                        <input type="radio" name="lactosa" id="lactosa_si" value="lactosa_si" onclick="toggleLactosa()" />Yes
                                                        <% } %>
                                                        <% else
                                                            { %>
                                                        <input type="radio" name="lactosa" id="lactosa_no" value="lactosa_no" onclick="toggleLactosa()" />No
                                                        <input type="radio" name="lactosa" id="lactosa_si" value="lactosa_si" onclick="toggleLactosa()"
                                                            checked="checked" />Yes
                                                        <% } %>
                                                    </fieldset>
                                                </td>
                                            </tr>
                                            <% if (m.Lactosa == true)
                                               { %>
                                            <tr id="tr_lactosa_si" style="display: none;">
                                                <% } %>
                                                <% else
                                                    { %>
                                                <tr id="tr_lactosa_si" style="display: block;">
                                                    <% } %>
                                                    <td valign="top" colspan="4">
                                                        <fieldset>
                                                            <legend class="text">How many dairy products do you take in a day? (*)</legend>
                                                            <table>
                                                                <% if (m.Num_lactosa == 1)
                                                                   { %>
                                                                <tr>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_1" value="1" checked="checked" />None<br />
                                                                    </td>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_2" value="2" />One<br />
                                                                    </td>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_3" value="3" />One in each meal<br />
                                                                    </td>
                                                                </tr>
                                                                <% } %>
                                                                <% else if (m.Num_lactosa == 2)
                                                                    { %>
                                                                <tr>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_1" value="1" />None<br />
                                                                    </td>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_2" value="2" checked="checked" />One<br />
                                                                    </td>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_3" value="3" />One in each meal<br />
                                                                    </td>
                                                                </tr>
                                                                <% } %>
                                                                <% else if (m.Num_lactosa == 3)
                                                                    { %>
                                                                <tr>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_1" value="1" />None<br />
                                                                    </td>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_2" value="2" />One<br />
                                                                    </td>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_3" value="3" checked="checked" />One in each meal<br />
                                                                    </td>
                                                                </tr>
                                                                <% }
                                                                    else
                                                                    { %>
                                                                <tr>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_1" value="1" />None<br />
                                                                    </td>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_2" value="2" />One<br />
                                                                    </td>
                                                                    <td>
                                                                        <input type="radio" name="num_lactosa" id="num_lactosa_3" value="3" />One in each meal<br />
                                                                    </td>
                                                                </tr>
                                                                <% } %>
                                                            </table>
                                                        </fieldset>
                                                    </td>
                                                </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" colspan="4">
                                    <table>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">11. Do you eat vegetables? (*)</legend>
                                                    <% if (m.Num_verd == 1)
                                                       { %>
                                                    <input type="radio" name="num_verd" id="num_verd_1" value="1" onclick="toggleVerdura()" checked="checked" />No
                                                    <input type="radio" name="num_verd" id="num_verd_2" value="2" onclick="toggleVerdura()" />Yes
                                                    <% } %>
                                                    <% else if (m.Num_verd == 2)
                                                       { %>
                                                    <input type="radio" name="num_verd" id="num_verd_1" value="1" onclick="toggleVerdura()" />No
                                                    <input type="radio" name="num_verd" id="num_verd_2" value="2" onclick="toggleVerdura()" checked="checked" />Yes
                                                    <% } %>
                                                    <% else
                                                       { %>
                                                    <input type="radio" name="num_verd" id="num_verd_1" value="1" onclick="toggleVerdura()" />No
                                                    <input type="radio" name="num_verd" id="num_verd_2" value="2" onclick="toggleVerdura()" />Yes
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <% if (m.Num_verd <= 1)
                                               { %>
                                            <tr id="tr_verd_si" style="display: none;">
                                                <% } %>
                                                <% else
                                                    { %>
                                                <tr id="tr_verd_si" style="display: block;">
                                                    <% } %>
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">Check the vegetable(s) you like</legend>
                                                    <table>
                                                        <tr>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Leaf or stem</legend>
                                                                    <% if (m.Esparrago == true)
                                                                       { %>
                                                                    <input type="checkbox" name="esparrago" id="esparrago" checked="checked" />Asparagus<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="esparrago" id="esparrago" />Asparagus<br />
                                                                    <% } %>
                                                                    <% if (m.Espinaca == true)
                                                                       { %>
                                                                    <input type="checkbox" name="espinaca" id="espinaca" checked="checked" />Spinach<br />
                                                                    <% } %>
                                                                    <% else { %>
                                                                    <input type="checkbox" name="espinaca" id="espinaca" />Spinach<br />
                                                                    <% } %>
                                                                    <% if (m.Acelga == true)
                                                                       { %>
                                                                    <input type="checkbox" name="acelga" id="acelga" checked="checked" />Chard<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="acelga" id="acelga" />Chard<br />
                                                                    <% } %>
                                                                    <% if (m.Cardo == true)
                                                                       { %>
                                                                    <input type="checkbox" name="cardo" id="cardo" checked="checked" />Thistle<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="cardo" id="cardo" />Thistle<br />
                                                                    <% } %>
                                                                    <% if (m.Borraja == true)
                                                                       { %>
                                                                    <input type="checkbox" name="borraja" id="borraja" checked="checked" />Borage<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="borraja" id="borraja" />Borage<br />
                                                                    <% } %>
                                                                    <% if (m.Lechuga == true)
                                                                       { %>
                                                                    <input type="checkbox" name="lechuga" id="lechuga" checked="checked" />Lettuce<br />
                                                                    <% } %>
                                                                    <% else { %>
                                                                    <input type="checkbox" name="lechuga" id="lechuga" />Lettuce<br />
                                                                    <% } %>
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Fruit</legend>
                                                                    <% if (m.Pepinillo == true)
                                                                       { %>
                                                                    <input type="checkbox" name="pepinillo" id="pepinillo" checked="checked" />Pickle<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="pepinillo" id="pepinillo" />Pickle<br />
                                                                    <% } %>
                                                                    <% if (m.Tomate == true)
                                                                       { %>
                                                                    <input type="checkbox" name="tomate" id="tomate" checked="checked" />Tomato<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="tomate" id="tomate" />Tomato<br />
                                                                    <% } %>
                                                                    <% if (m.Pimiento == true)
                                                                       { %>
                                                                    <input type="checkbox" name="pimiento" id="pimiento" checked="checked" />Pepper<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="pimiento" id="pimiento" />Pepper<br />
                                                                    <% } %>
                                                                    <% if (m.Berenjena == true)
                                                                       { %>
                                                                    <input type="checkbox" name="berenjena" id="berenjena" checked="checked" />Eggplant<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="berenjena" id="berenjena" />Eggplant<br />
                                                                    <% } %>
                                                                    <% if (m.Calabacin == true)
                                                                       { %>
                                                                    <input type="checkbox" name="calabacin" id="calabacin" checked="checked" />Zucchini<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="calabacin" id="calabacin" />Zucchini<br />
                                                                    <% } %>
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Flower</legend>
                                                                    <% if (m.Alcachofa == true)
                                                                       { %>
                                                                    <input type="checkbox" name="alcachofa" id="alcachofa" checked="checked" />Artichoke<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="alcachofa" id="alcachofa" />Artichoke<br />
                                                                    <% } %>
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Roots and bulbs</legend>
                                                                    <% if (m.Puerro == true)
                                                                       { %>
                                                                    <input type="checkbox" name="puerro" id="puerro" checked="checked" />Leek<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="puerro" id="puerro" />Leek<br />
                                                                    <% } %>
                                                                    <% if (m.Ajo == true)
                                                                       { %>
                                                                    <input type="checkbox" name="ajo" id="ajo" checked="checked" />Garlic<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="ajo" id="ajo" />Garlic<br />
                                                                    <% } %>
                                                                    <% if (m.Cebolla == true)
                                                                       { %>
                                                                    <input type="checkbox" name="cebolla" id="cebolla" checked="checked" />Onion<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="cebolla" id="cebolla" />Onion<br />
                                                                    <% } %>
                                                                    <% if (m.Nabo == true)
                                                                       { %>
                                                                    <input type="checkbox" name="nabo" id="nabo" checked="checked" />Turnip<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="nabo" id="nabo" />Turnip<br />
                                                                    <% } %>
                                                                    <% if (m.Patata == true)
                                                                       { %>
                                                                    <input type="checkbox" name="patata" id="patata" checked="checked" />Potato<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="patata" id="patata" />Potato<br />
                                                                    <% } %>
                                                                    <% if (m.Rabanos == true)
                                                                       { %>
                                                                    <input type="checkbox" name="rabanos" id="rabanos" checked="checked" />Radishes<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="rabanos" id="rabanos" />Radishes<br />
                                                                    <% } %>
                                                                    <% if (m.Remolacha == true)
                                                                       { %>
                                                                    <input type="checkbox" name="remolacha" id="remolacha" checked="checked" />Table beet<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="remolacha" id="remolacha" />Table beet<br />
                                                                    <% } %>
                                                                    <% if (m.Zanahoria == true)
                                                                       { %>
                                                                    <input type="checkbox" name="zanahoria" id="zanahoria" checked="checked" />Carrot<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="zanahoria" id="zanahoria" />Carrot<br />
                                                                    <% } %>
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Legumes</legend>
                                                                    <% if (m.Judias == true)
                                                                       { %>
                                                                    <input type="checkbox" name="judias" id="judias" checked="checked" />Green beans<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="judias" id="judias" />Green beans<br />
                                                                    <% } %>
                                                                    <% if (m.Guisantes == true)
                                                                       { %>
                                                                    <input type="checkbox" name="guisantes" id="guisantes" checked="checked" />Peas<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="guisantes" id="guisantes" />Peas<br />
                                                                    <% } %>
                                                                    <% if (m.Lentejas == true)
                                                                       { %>
                                                                    <input type="checkbox" name="lentejas" id="lentejas" checked="checked" />Lentils<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="lentejas" id="lentejas" />Lentils<br />
                                                                    <% } %>
                                                                    <% if (m.Alubias == true)
                                                                       { %>
                                                                    <input type="checkbox" name="alubias" id="alubias" checked="checked" />Beans<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="alubias" id="alubias" />Beans<br />
                                                                    <% } %>
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Cabbages</legend>
                                                                    <% if (m.Repollo == true)
                                                                       { %>
                                                                    <input type="checkbox" name="repollo" id="repollo" checked="checked" />Cabbage<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="repollo" id="repollo" />Cabbage<br />
                                                                    <% } %>
                                                                    <% if (m.Brecol == true)
                                                                       { %>
                                                                    <input type="checkbox" name="brecol" id="brecol" checked="checked" />Brecol<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="brecol" id="brecol" />Brecol<br />
                                                                    <% } %>
                                                                    <% if (m.Coles == true)
                                                                       { %>
                                                                    <input type="checkbox" name="coles" id="coles" checked="checked" />Brussels sprouts<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="coles" id="coles" />Brussels sprouts<br />
                                                                    <% } %>
                                                                    <% if (m.Coliflor == true)
                                                                       { %>
                                                                    <input type="checkbox" name="coliflor" id="coliflor" checked="checked" />Cauliflower<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="coliflor" id="coliflor" />Cauliflower<br />
                                                                    <% } %>
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Various vegetables</legend>
                                                                    <% if (m.Champinnon == true)
                                                                       { %>
                                                                    <input type="checkbox" name="champinnon" id="champinnon" checked="checked" />Button mushroom<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="champinnon" id="champinnon" />Button mushroom<br />
                                                                    <% } %>
                                                                    <% if (m.Setas == true)
                                                                       { %>
                                                                    <input type="checkbox" name="setas" id="setas" checked="checked" />Mushrooms<br />
                                                                    <% } %>
                                                                    <% else
                                                                        { %>
                                                                    <input type="checkbox" name="setas" id="setas" />Mushrooms<br />
                                                                    <% } %>
                                                                </fieldset>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </fieldset>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" colspan="4">
                                    <table>
                                       <tr>
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">12. Basic food</legend>
                                                    <% if (m.Huevos == true)
                                                       { %>
                                                    <input type="checkbox" name="huevos" id="huevos" checked="checked" />Eggs<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="huevos" id="huevos" />Huevos<br />
                                                    <% } %>
                                                    <% if (m.Pan == true)
                                                       { %>
                                                    <input type="checkbox" name="pan" id="pan" checked="checked" />Bread<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="pan" id="pan" />Bread<br />
                                                    <% } %>
                                                    <% if (m.Arroz == true)
                                                       { %>
                                                    <input type="checkbox" name="arroz" id="arroz" checked="checked" />Rice<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="arroz" id="arroz" />Rice<br />
                                                    <% } %>
                                                    <% if (m.Pasta == true)
                                                       { %>
                                                    <input type="checkbox" name="pasta" id="pasta" checked="checked" />Pasta<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="pasta" id="pasta" />Pasta<br />
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">13. Type of feed (*)</legend>
                                                    <% if (m.Tipo == true)
                                                       { %>
                                                    <input type="radio" name="tipo" id="tipo_veg" value="1" onclick="toggleCarne()" checked="checked" />Vegetarian
                                                    <input type="radio" name="tipo" id="tipo_carne" value="2" onclick="toggleCarne()" />Carnivorous
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="radio" name="tipo" id="tipo_veg" value="1" onclick="toggleCarne()" />Vegetarian
                                                    <input type="radio" name="tipo" id="tipo_carne" value="2" onclick="toggleCarne()" checked="checked" />Carnivorous
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <% if (m.Tipo == true)
                                               { %>
                                            <tr id="tr_tipo_carne" style="display: none;">
                                                <% } %>
                                                <% else
                                                    { %>
                                                <tr id="tr_tipo_carne" style="display: block;">
                                                    <% } %>
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">Indicate the food you eat</legend>
                                                    <% if (m.Pescado == true)
                                                       { %>
                                                    <input type="checkbox" name="pescado" id="pescado" checked="checked" />Fish<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="pescado" id="pescado" />Fish<br />
                                                    <% } %>
                                                    <% if (m.Carne == true)
                                                       { %>
                                                    <input type="checkbox" name="carne" id="carne" checked="checked" />Meat<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="carne" id="carne" />Meat<br />
                                                    <% } %>
                                                    <% if (m.Pollo == true)
                                                       { %>
                                                    <input type="checkbox" name="pollo" id="pollo" checked="checked" />Chicken<br />
                                                    <% } %>
                                                    <% else
                                                        { %>
                                                    <input type="checkbox" name="pollo" id="pollo" />Chicken<br />
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">14. Activity level (*)</legend>
                                                    <% if (m.Estilo == 1)
                                                       { %>
                                                    <input type="radio" name="estilo" id="estilo_1" value="1" checked="checked" />Sedentary
                                                    <input type="radio" name="estilo" id="estilo_2" value="2" />Moderately active
                                                    <input type="radio" name="estilo" id="estilo_3" value="3" />Active
                                                    <% } %>
                                                    <% else if (m.Estilo == 2)
                                                       { %>
                                                    <input type="radio" name="estilo" id="estilo_1" value="1" />Sedentary
                                                    <input type="radio" name="estilo" id="estilo_2" value="2" checked="checked" />Moderately active
                                                    <input type="radio" name="estilo" id="estilo_3" value="3" />Active
                                                    <% } %>
                                                    <% else if (m.Estilo == 3)
                                                       { %>
                                                    <input type="radio" name="estilo" id="estilo_1" value="1" />Sedentary
                                                    <input type="radio" name="estilo" id="estilo_2" value="2" />Moderadately active
                                                    <input type="radio" name="estilo" id="estilo_3" value="3" checked="checked" />Active
                                                    <% } %>
                                                    <% else
                                                       { %>
                                                    <input type="radio" name="estilo" id="estilo_1" value="1" />Sedentary
                                                    <input type="radio" name="estilo" id="estilo_2" value="2" />Moderadately active
                                                    <input type="radio" name="estilo" id="estilo_3" value="3" />Active
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">15. Budget (*)</legend>
                                                    <% if (m.Presupuesto == 1)
                                                       { %>
                                                    <input type="radio" name="presupuesto" id="presupuesto_1" value="1" checked="checked" />Low
                                                    <input type="radio" name="presupuesto" id="presupuesto_2" value="2" />Medium
                                                    <input type="radio" name="presupuesto" id="presupuesto_3" value="3" />High
                                                    <% } %>
                                                    <% else if (m.Presupuesto == 2)
                                                        { %>
                                                    <input type="radio" name="presupuesto" id="presupuesto_1" value="1" />Low
                                                    <input type="radio" name="presupuesto" id="presupuesto_2" value="2" checked="checked" />Medium
                                                    <input type="radio" name="presupuesto" id="presupuesto_3" value="3" />High
                                                    <% } %>
                                                    <% else if (m.Presupuesto == 3)
                                                        { %>
                                                    <input type="radio" name="presupuesto" id="presupuesto_1" value="1" />Low
                                                    <input type="radio" name="presupuesto" id="presupuesto_2" value="2" />Medium
                                                    <input type="radio" name="presupuesto" id="presupuesto_3" value="3" checked="checked" />High
                                                    <% } %>
                                                    <% else
                                                    { %>
                                                    <input type="radio" name="presupuesto" id="presupuesto_1" value="1" />Low
                                                    <input type="radio" name="presupuesto" id="presupuesto_2" value="2" />Medium
                                                    <input type="radio" name="presupuesto" id="presupuesto_3" value="3" />High
                                                    <% } %>
                                                </fieldset>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        <asp:Button ID="Actualizar" runat="server" Text="UPDATE" OnClick="Actualizar_Click" />
                    </fieldset>
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</body>
</html>
