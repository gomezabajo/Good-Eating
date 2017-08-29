<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CuestionarioC.aspx.cs" Inherits="_CuestionarioC" %>

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
                        <legend class="text">QUESTIONNAIRE. TASTES (EATING HABITS). PART 3/5</legend>
                        <table>
                            <tr>
                                <td valign="top">
                                    <table>
                                        <tr>
                                            <td colspan="4" align="left">
                                                <fieldset>
                                                    <legend class="text">9. Do you eat fruit?
                                                        (*)</legend>
                                                    <input type="radio" name="num_fruta" id="num_fruta_1" value="1" onclick="toggleFruta()" />No
                                                    <input type="radio" name="num_fruta" id="num_fruta_2" value="2" onclick="toggleFruta()" />Yes
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr id="tr_fruta_si" style="display: none;">
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">Check the fruit(s) you like</legend>
                                                    <table>
                                                        <tr>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Sweet</legend>
                                                                    <input type="checkbox" name="platano" id="platano" />Banana<br />
                                                                    <input type="checkbox" name="cereza" id="cereza" />Cherry<br />
                                                                    <input type="checkbox" name="ciruela" id="ciruela" />Plum<br />
                                                                    <input type="checkbox" name="guayaba" id="guayaba" />Guava<br />
                                                                    <input type="checkbox" name="guanabana" id="guanabana" />Soursop<br />
                                                                    <input type="checkbox" name="higo" id="higo" />Fig<br />
                                                                    <input type="checkbox" name="pera" id="pera" />Pear<br />
                                                                    <input type="checkbox" name="albaricoque" id="albaricoque" />Apricot<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Acid</legend>
                                                                    <input type="checkbox" name="limon" id="limon" />Lemon<br />
                                                                    <input type="checkbox" name="naranja" id="naranja" />Orange<br />
                                                                    <input type="checkbox" name="pinna" id="pinna" />Pineapple<br />
                                                                    <input type="checkbox" name="tamarindo" id="tamarindo" />Tamarind<br />
                                                                    <input type="checkbox" name="toronja" id="toronja" />Grapefruit<br />
                                                                    <input type="checkbox" name="uva" id="uva" />Grape<br />
                                                                    <input type="checkbox" name="manzana" id="manzana" />Apple<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Semi-acid</legend>
                                                                    <input type="checkbox" name="melocoton" id="melocoton" />Peach<br />
                                                                    <input type="checkbox" name="fresa" id="fresa" />Strawberry<br />
                                                                    <input type="checkbox" name="mandarina" id="mandarina" />Tangerine<br />
                                                                    <input type="checkbox" name="lima" id="lima" />Lime<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Neutral</legend>
                                                                    <input type="checkbox" name="aguacate" id="aguacate" />Avocado<br />
                                                                    <input type="checkbox" name="aceituna" id="aceituna" />Olive<br />
                                                                    <input type="checkbox" name="avellana" id="avellana" />Hazelnut<br />
                                                                    <input type="checkbox" name="coco" id="coco" />Coconut<br />
                                                                    <input type="checkbox" name="nuez" id="nuez" />Nut<br />
                                                                    <input type="checkbox" name="cacao" id="cacao" />Cocoa<br />
                                                                    <input type="checkbox" name="durazno" id="durazno" />Small peach<br />
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
                                                    <input type="radio" name="lactosa" id="lactosa_no" value="lactosa_no" onclick="toggleLactosa()" />No
                                                    <input type="radio" name="lactosa" id="lactosa_si" value="lactosa_si" onclick="toggleLactosa()" />Yes
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr id="tr_lactosa_si" style="display: none;">
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">How many dairy products do you take in a day? (*)</legend>
                                                    <table>
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
                                                    </table>
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
