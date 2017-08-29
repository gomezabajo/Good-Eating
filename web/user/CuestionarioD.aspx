<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CuestionarioD.aspx.cs" Inherits="_CuestionarioD" %>

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
        function toggleVerdura() {
            var val = document.getElementById('num_verd_2');
            if (val.checked == true) {
                document.getElementById('tr_verd_si').style.display = 'none';
            }
            else {
                document.getElementById('tr_verd_si').style.display = 'block';
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
                        <legend class="text">QUESTIONNAIRE. TASTES (EATING HABITS). PART 4/5</legend>
                        <table>
                            <tr>
                                <td valign="top">
                                    <table>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">11. Do you eat vegetables? (*)</legend>
                                                    <input type="radio" name="num_verd" id="num_verd_1" value="1" onclick="toggleVerdura()" />No
                                                    <input type="radio" name="num_verd" id="num_verd_2" value="2" onclick="toggleVerdura()" />Yes
                                                </fieldset>
                                            </td>
                                        </tr>
                                        <tr id="tr_verd_si" style="display: none;">
                                            <td valign="top" colspan="4">
                                                <fieldset>
                                                    <legend class="text">Check the vegetable(s) you like</legend>
                                                    <table>
                                                        <tr>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Leaf or stem</legend>
                                                                    <input type="checkbox" name="esparrago" id="esparrago" />Asparagus<br />
                                                                    <input type="checkbox" name="espinaca" id="espinaca" />Spinach<br />
                                                                    <input type="checkbox" name="acelga" id="acelga" />Chard<br />
                                                                    <input type="checkbox" name="cardo" id="cardo" />Thistle<br />
                                                                    <input type="checkbox" name="borraja" id="borraja" />Borage<br />
                                                                    <input type="checkbox" name="lechuga" id="lechuga" />Lettuce<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Fruit</legend>
                                                                    <input type="checkbox" name="pepinillo" id="pepinillo" />Pickle<br />
                                                                    <input type="checkbox" name="tomate" id="tomate" />Tomato<br />
                                                                    <input type="checkbox" name="pimiento" id="pimiento" />Pepper<br />
                                                                    <input type="checkbox" name="berenjena" id="berenjena" />Eggplant<br />
                                                                    <input type="checkbox" name="calabacin" id="calabacin" />Zucchini<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Flower</legend>
                                                                    <input type="checkbox" name="alcachofa" id="alcachofa" />Artichoke<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Roots and bulbs</legend>
                                                                    <input type="checkbox" name="puerro" id="puerro" />Leek<br />
                                                                    <input type="checkbox" name="ajo" id="ajo" />Garlic<br />
                                                                    <input type="checkbox" name="cebolla" id="cebolla" />Onion<br />
                                                                    <input type="checkbox" name="nabo" id="nabo" />Turnip<br />
                                                                    <input type="checkbox" name="rabanos" id="rabanos" />Radishes<br />
                                                                    <input type="checkbox" name="remolacha" id="remolacha" />Table beet<br />
                                                                    <input type="checkbox" name="patata" id="patata" />Potato<br />
                                                                    <input type="checkbox" name="zanahoria" id="zanahoria" />Carrot<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Legumes</legend>
                                                                    <input type="checkbox" name="judias" id="judias" />Green beans<br />
                                                                    <input type="checkbox" name="guisantes" id="guisantes" />Peas<br />
                                                                    <input type="checkbox" name="lentejas" id="lentejas" />Lentils<br />
                                                                    <input type="checkbox" name="alubias" id="alubias" />Beans<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Cabbages</legend>
                                                                    <input type="checkbox" name="repollo" id="repollo" />Cabbage<br />
                                                                    <input type="checkbox" name="brecol" id="brecol" />Brecol<br />
                                                                    <input type="checkbox" name="coles" id="coles" />Brussels sprouts<br />
                                                                    <input type="checkbox" name="coliflor" id="coliflor" />Cauliflower<br />
                                                                </fieldset>
                                                            </td>
                                                            <td valign="top">
                                                                <fieldset style="width: 140px;">
                                                                    <legend class="text">Various vegetables</legend>
                                                                    <input type="checkbox" name="champinnon" id="champinnon" />Button mushrooom<br />
                                                                    <input type="checkbox" name="setas" id="setas" />Mushrooms<br />
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
