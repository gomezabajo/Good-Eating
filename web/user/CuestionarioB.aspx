<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CuestionarioB.aspx.cs" Inherits="_CuestionarioB" %>

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
    <fieldset>
        <table>
            <tr>
                <td width="1000px">
                    <fieldset>
                        <legend class="text">QUESTIONNAIRE. HEALTH INFORMATION. PART 2/5</legend>
                        <table>
                            <tr>
                                <td valign="top">
                                    <table>
                                        <tr>
                                            <td>
                                                <fieldset>
                                                    <legend class="text">8. Check the box if you suffer of any of these illnesses</legend>
                                                    <input type="checkbox" name="diabetes" id="diabetes" />Diabetes<br />
                                                    <input type="checkbox" name="colesterol" id="colesterol" />Cholesterol<br />
                                                    <input type="checkbox" name="hepatica" id="hepatica" />Liver failure<br />
                                                    <input type="checkbox" name="renal" id="renal" />Renal insufficiency<br />
                                                    <input type="checkbox" name="pancreas" id="pancreas" />Pancreatic diseases<br />
                                                    <input type="checkbox" name="bilis" id="bilis" />Problems in the gallbladder<br />
                                                    <input type="checkbox" name="ulcera" id="ulcera" />Ulcer<br />
                                                    <input type="checkbox" name="colitis" id="colitis" />Ulcerative colitis<br />
                                                    <input type="checkbox" name="colon" id="colon" />Irritable colon<br />
                                                    <input type="checkbox" name="intestino" id="intestino" />Inflammation of the intestines
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
