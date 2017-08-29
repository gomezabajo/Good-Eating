<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CuestionarioE.aspx.cs" Inherits="_CuestionarioE" %>

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
            height: 140px;
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
    <fieldset>
        <table>
            <tr>
                <td width="1000px">
                    <fieldset>
                        <legend class="text">QUESTIONNAIRE. FOOD CONSUMPTION AND BUDGET. PART 5/5</legend>
                        <table>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">12. Basic food</legend>
                                                    <input type="checkbox" name="huevos" id="huevos" />Eggs<br />
                                                    <input type="checkbox" name="pan" id="pan" />Bread<br />
                                                    <input type="checkbox" name="arroz" id="arroz" />Rice<br />
                                                    <input type="checkbox" name="pasta" id="pasta" />Pasta<br />
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">13. Type of feed (*)</legend>
                                                    <input type="radio" name="tipo" id="tipo_veg" value="1" onclick="toggleCarne()" />Vegetarian
                                                    <input type="radio" name="tipo" id="tipo_carne" value="2" onclick="toggleCarne()" />Carnivorous
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr id="tr_tipo_carne" style="display: none;">
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">Indicate the food you eat</legend>
                                                    <input type="checkbox" name="pescado" id="pescado" />Fish<br />
                                                    <input type="checkbox" name="carne" id="carne" />Meat<br />
                                                    <input type="checkbox" name="pollo" id="pollo" />Chicken<br />
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">14. Activity level (*)</legend>
                                                    <input type="radio" name="estilo" id="estilo_1" value="1" />Sedentary
                                                    <input type="radio" name="estilo" id="estilo_2" value="2" />Moderately active
                                                    <input type="radio" name="estilo" id="estilo_3" value="3" />Active
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">15. Budget (*)</legend>
                                                    <input type="radio" name="presupuesto" id="presupuesto_1" value="1" />Low
                                                    <input type="radio" name="presupuesto" id="presupuesto_2" value="2" />Medium
                                                    <input type="radio" name="presupuesto" id="presupuesto_3" value="3" />High
                                                </fieldset>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        <asp:Button ID="Finalizar" runat="server" Text="FINALIZE" OnClick="Finalizar_Click" />
                    </fieldset>
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</body>
</html>
