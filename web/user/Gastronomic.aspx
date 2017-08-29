<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Gastronomic.aspx.cs" Inherits="Gastronomic" %>

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
                        <legend class="text">GOOD EATING</legend><span class="text">Constituion
                            <%= m.Complexion %></span><br />
                        <span class="text">Recommended daily calories:
                            <%= m.Calorias %>
                            Kcal</span>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset>
                        <legend class="text">Number of days (*)</legend>
                        <select name="id_num_dias" id="id_num_dias">
                            <option value="0">Select</option>
                            <% for (int i = 1; i < 8; i++)
                               { %>
                            <option value="<%= i %>">
                                <%= i %></option>
                            <% } %>
                        </select>
                        <asp:Button ID="Generar" runat="server" Text="GENERATE" OnClick="Generar_Click" />
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset>
                        <legend class="text">Recommendation</legend>
                        <% for (int i = 0; i < dias; i++) {%>
                        <hr />
                        <span class="text">
                            <b><%= hoy.AddDays(i).ToString("dddd, dd MMMM yyyy", culture) %></b></span><hr />
                        <span class="text"><b>Breakfast:</b>
                            <%= (mdr[i].Desayuno_primero != null) ? mdr[i].Desayuno_primero.Nombre : string.Empty %>, <%= (mdr[i].Desayuno_segundo != null) ? mdr[i].Desayuno_segundo.Nombre : string.Empty %></span><br />
                        <span class="text"><b>Lunch:</b>
                            <%= (mdr[i].Comida_primero != null) ? mdr[i].Comida_primero.Nombre : string.Empty %>, <%= (mdr[i].Comida_segundo != null) ? mdr[i].Comida_segundo.Nombre : string.Empty %>, <%= (mdr[i].Comida_postre != null) ? mdr[i].Comida_postre.Nombre : string.Empty %></span><br />
                        <span class="text"><b>Snack:</b>
                            <%= (mdr[i].Merienda_primero != null) ? mdr[i].Merienda_primero.Nombre : string.Empty %>, <%= (mdr[i].Merienda_segundo != null) ? mdr[i].Merienda_segundo.Nombre : string.Empty %></span><br />
                        <span class="text"><b>Dinner:</b>
                            <%= (mdr[i].Cena_primero != null) ? mdr[i].Cena_primero.Nombre : string.Empty %>, <%= (mdr[i].Cena_segundo != null) ? mdr[i].Cena_segundo.Nombre : string.Empty %>, <%= (mdr[i].Cena_postre != null) ? mdr[i].Cena_postre.Nombre : string.Empty %></span><br />
                        <% } %>
                    </fieldset>
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</body>
</html>
