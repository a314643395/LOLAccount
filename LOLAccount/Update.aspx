<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="LOLAccount.UseSqlScript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtSql" runat="server" Height="178px" TextMode="MultiLine" Width="370px"></asp:TextBox>
        <asp:Button ID="brn_ex" runat="server" Height="36px" OnClick="brn_ex_Click" Text="执行SQL" Width="136px" />
        &nbsp;&nbsp;
        <asp:Button ID="brn_ex0" runat="server" Height="36px" OnClick="brn_ex0_Click" Text="清空" Width="136px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="提示：" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="UPDATE LOLAccount" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="INSERT INTO LOLAccount" />
        &nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="更改查看权限 1开放 0关闭" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
