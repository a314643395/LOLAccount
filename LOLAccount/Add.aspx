<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="LOLAccount.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新增</title>
    <style type="text/css">
        .auto-style1 {
            background:url(https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1510044962564&di=30f625d8e05f67baabf4bd844bc255c2&imgtype=0&src=http%3A%2F%2Fpic1.win4000.com%2Fwallpaper%2F1%2F58f8480556bf4.jpg) repeat-y left top;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
        <center>
            

            <br />
            <br />
            QQ<br />
            <asp:TextBox ID="txtQQ" runat="server"></asp:TextBox>
            <br />
            <br />
            密码<br />
            <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
            <br />
            <br />
            昵称<br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            段位<br />
            <asp:TextBox ID="txtDw" runat="server"></asp:TextBox>
            <br />
            <br />
            英雄数<br />
            <asp:TextBox ID="txtYxs" runat="server"></asp:TextBox>
            <br />
            <br />
            皮肤数<br />
            <asp:TextBox ID="txtPfs" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="36px" OnClick="Button1_Click" Text="新 增" Width="127px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            

        </center>
    
    </div>
    </form>
</body>
</html>
