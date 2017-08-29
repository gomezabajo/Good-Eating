<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="_Registro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <title>UAM</title>
    <link href="../css/vn_sistema.css" rel="stylesheet" type="text/css" />
    <link href="../css/site.css" rel="stylesheet" type="text/css" />
    <link href="../css/gastronomic.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        html, body
        {
            margin: 0px;
            height: 100%;
        }
    </style>

    <script type="text/javascript">
        function toggleFamSaved() {
            var val = document.getElementById('fam_saved');
            if (val.checked == true) {
                document.getElementById('div_fam_new').style.display = 'none';
                document.getElementById('div_fam_saved').style.display = 'block';
            }
            else {
                document.getElementById('div_fam_new').style.display = 'block';
                document.getElementById('div_fam_saved').style.display = 'none';
            }
        }
        function toggleFamNew() {
            var val = document.getElementById('fam_new');
            if (val.checked == true) {
                document.getElementById('div_fam_new').style.display = 'block';
                document.getElementById('div_fam_saved').style.display = 'none';
            }
            else {
                document.getElementById('div_fam_new').style.display = 'none';
                document.getElementById('div_fam_saved').style.display = 'block';
            }
        }
    </script>

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
    </div>
    <div id="content">
        <fieldset style="text-align: left;">
            <legend class="text">New user</legend>
            <div id="opciones">
                <a href="Login.aspx">Back</a>
            </div>
            <div id="datos">
                <table>
                    <tr>
                        <td valign="top">
                            <table border="0">
                                <tr>
                                    <td valign="top">
                                        <fieldset>
                                            <legend class="text">User</legend>
                                            <p>
                                                Login:</p>
                                            <input name="usuario" type="text" value="" size="20" maxlength="20" />(*)
                                            <p>
                                                Password:</p>
                                            <input name="clave" value="" size="20" maxlength="20" type="password" />(*)
                                            <p>
                                                Repeat your password:</p>
                                            <input name="clave_rep" value="" size="20" maxlength="20" type="password" />(*)
                                            <p>
                                                Name:</p>
                                            <input name="nombre_user" type="text" value="" size="50" maxlength="100" />(*)
                                            <p>
                                                Surname:</p>
                                            <input name="apellidos_user" type="text" value="" size="50" maxlength="100" />(*)
                                            <p>
                                                Email:</p>
                                            <input name="email_user" type="text" value="" size="40" maxlength="150" />(*)
                                            <p>
                                                Notes:</p>
                                            <textarea name="notas_user" cols="40" rows="5"></textarea>
                                        </fieldset>
                                        <br />
                                        <br />
                                        <asp:Button runat="server" ID="Insertar" Text="Guardar usuario" OnClick="Insertar_Click" />
                                        <br />
                                        <br />
                                        (*) Mandatory fields
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td valign="top">
                            <table>
                                <tr>
                                    <td valign="top">
                                        <fieldset>
                                            <legend class="text">Family</legend>
                                            <input type="radio" name="fam" id="fam_new" value="fam_new" onclick="toggleFamNew()" />Create new family
                                            <input type="radio" name="fam" id="fam_saved" value="fam_saved" onclick="toggleFamSaved()" />Join an existing family
                                            <div id="div_fam_saved" style="display: none;">
                                                <p>
                                                    Family
                                                </p>
                                                <select name="id_fam" id="id_fam">
                                                    <option value="0">Select</option>
                                                    <% foreach (Familia fam in lfam)
                                                       { %>
                                                    <option value="<%= fam.Id %>">
                                                        <%= fam.Nombre%></option>
                                                    <% } %>
                                                </select>(*)
                                                <p>
                                                    Family password:</p>
                                                <input name="clave_fam_check" value="" size="20" maxlength="20" type="password" />(*)
                                            </div>
                                            <div id="div_fam_new" style="display: none;">
                                                <p>
                                                    Family name:</p>
                                                <input name="nombre_fam" type="text" value="" size="50" maxlength="100" />(*)
                                                <p>
                                                    Family password:</p>
                                                <input name="clave_fam" value="" size="20" maxlength="20" type="password" />(*)
                                                <p>
                                                    Repeat the family password:</p>
                                                <input name="clave_fam_rep" value="" size="20" maxlength="20" type="password" />(*)
                                                <p>
                                                    Family email:</p>
                                                <input name="email_fam" type="text" value="" size="40" maxlength="150" />(*)
                                                <p>
                                                    Notes:</p>
                                                <textarea name="notas_fam" cols="40" rows="5"></textarea>
                                            </div>
                                        </fieldset>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
