<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CuestionarioA.aspx.cs" Inherits="_CuestionarioA" %>

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
            scrollbar-darkshado-color: #000000;
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
    <fieldset>
        <table>
            <tr>
                <td width="1000px">
                    <fieldset>
                        <legend class="text">QUESTIONNAIRE. PERSONAL INFORMATION. PART 1/5</legend>
                        <table>
                            <tr>
                                <td valign="top">
                                    <table>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">1. Sex (*)</legend>
                                                    <input type="radio" name="gen" id="gen_mas" value="1" />Male
                                                    <input type="radio" name="gen" id="gen_fem" value="2" />Female
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
                                                    <input type="text" name="estatura" id="estatura" value="" />&nbsp;(m.)
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">4. Weight (*)</legend>
                                                    <input type="text" name="peso" id="peso" value="" />&nbsp;(kg.)
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
                                                        <option value="<%= i %>"><%= i %></option>
                                                        <% } %>
                                                    </select>
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">6. Religion (*)</legend>
                                                    <input type="radio" name="religion" id="cristiano" value="cristiano" />Christian<br />
                                                    <input type="radio" name="religion" id="musulman" value="musulman" />Muslim<br />
                                                    <input type="radio" name="religion" id="judio" value="judio" />Jew<br />
                                                    <input type="radio" name="religion" id="no_procede" value="no_procede" />Not applicable
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
                        </table>
                        <asp:Button ID="Continuar" runat="server" Text="CONTINUE" OnClick="Continuar_Click" />
                    </fieldset>
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</body>
</html>
