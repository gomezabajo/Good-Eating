<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="Menu" %>
<link href="../menu/csshorizontalmenu.css" rel="stylesheet" type="text/css" />
<script src="../menu/csshorizontalmenu.js" type="text/javascript"></script>

<!-- COMIENZO MENÚ PRINCIPAL -->
<div class="horizontalcssmenu">
    <ul id="cssmenu1">
        <li><a href="Menu.aspx">General information</a>
            <ul>
                <li><a href="Modelado.aspx">User modelling</a></li>
                <li><a href="Gastronomic.aspx">Good eating recommendations</a></li>
            </ul>
        </li>
        <li><a href="Help.aspx">Help</a> </li>
        <li><a href="Logout.aspx">Logout</a></li>
    </ul>
    <br style="clear: left;" />
</div>
<!-- FINAL MENÚ PRINCIPAL -->
