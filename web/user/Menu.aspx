<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="_Menu" %>
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
        <h1 class="parrafo_001">UAM</h1>
    </div>
    <div id="location">
        <h2>
            GOOD EATING</h2>
        <p>
        </p>
    </div>
    <cc:Menu runat="server" />
    </form>
</body>
</html>
