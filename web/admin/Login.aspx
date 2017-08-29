<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <title>UAM</title>
    <link href="../css/vn_sistema.css" rel="stylesheet" type="text/css" />
    <link href="../css/site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        html, body
        {
            margin: 0px;
            height: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="960" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td height="170" colspan="1" background="../css/img/cabecera.jpg">
                    <div class="principal">
                    </div>
                </td>
            </tr>
        </table>
        <table width="1029" border="0" align="center" cellpadding="0" cellspacing="30">
            <tr>
                <td valign="top" class="recuadro_005" id="subtitle">
                    <h3>
                        Welcome to GOOD EATING v1.0 management area</h3>
                    <div class="divider">
                    </div>
                    <table align="left" cellspacing="5">
                        <tr>
                            <td class="text">
                                <div align="left">
                                    <img src="../css/img/candado.png" alt="" />&nbsp;Login:</div>
                            </td>
                            <td width="200">
                                <span class="text">
                                    <input name="usuario" type="text" class="campo_001" size="31" maxlength="20" />
                                </span>
                            </td>
                        </tr>
                        <tr>
                            <td class="text">
                                <div align="left">
                                    <img src="../css/img/candado.png" alt="" />&nbsp;Password:</div>
                            </td>
                            <td width="200">
                                <span class="text">
                                    <input name="clave" type="password" class="campo_001" size="31" maxlength="20" />
                                </span>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:Button ID="Acceso" runat="server" Text="SIGN IN" CssClass="botonnaranja" OnClick="Acceso_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
