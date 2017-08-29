<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="Menu" %>
<link href="../menu/csshorizontalmenu.css" rel="stylesheet" type="text/css" />
<script src="../menu/csshorizontalmenu.js" type="text/javascript"></script>

<!-- COMIENZO MENÚ PRINCIPAL -->
<div class="horizontalcssmenu">
    <ul id="cssmenu1">
        <li><a href="#">System</a>
            <ul>
                <li><a href="User.aspx">Users</a></li>
                <li><a href="UserRemoved.aspx">Removed Users</a></li>
                <li><a href="Family.aspx">Families</a></li>
                <li><a href="RemovedFamily.aspx">Removed Families</a></li>
            </ul>
        </li>
        <li><a href="Search.aspx">Search</a></li>
        <li><a href="Summary.aspx">Summary</a>
            <ul>
                <li><a href="Summary.aspx">Users Summary</a></li>
                <li><a href="SummaryFamily.aspx">Families Summary</a></li>
            </ul>
        </li>
        <li><a href="Log.aspx">Accesses</a>
            <ul>
                <li><a href="Log.aspx">Accesses List</a></li>
                <li><a href="SearchLog.aspx">Search Accesses</a></li>
            </ul>
        </li>
        <li><a href="Help.pdf" target="_blank">Help</a> </li>
        <li><a href="Logout.aspx">Logout</a></li>
    </ul>
    <br style="clear: left;" />
</div>
<!-- FINAL MENÚ PRINCIPAL -->
