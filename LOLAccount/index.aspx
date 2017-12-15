<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LOLAccount.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录 - 暗影岛轰炸机</title>
    <%--    <link rel="stylesheet" href="css/jquery.zySlide.css">
    <style>
	.zy-Slide section{ color: #FFFFFF; border-width: 1px; border-style: solid; }
</style>--%>

    <style type="text/css">
        .auto-style1 {
            background:url(https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1510044962564&di=30f625d8e05f67baabf4bd844bc255c2&imgtype=0&src=http%3A%2F%2Fpic1.win4000.com%2Fwallpaper%2F1%2F58f8480556bf4.jpg) repeat-y left top;
            height: 653px;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    <center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="输入QQ号登录"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtLogin" runat="server" BorderColor="#66CCFF" Font-Bold="True" Font-Size="X-Large" Height="25px" Width="207px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnLogin" runat="server" BackColor="White" BorderColor="#99CCFF" Font-Bold="True" ForeColor="#FF6600" Height="25px" OnClick="btnLogin_Click" style="margin-top: 0px" Text="确 认" Width="88px" BorderStyle="Inset" />
        </asp:Panel>
        <br />
        <asp:Label ID="lbl0" runat="server" ForeColor="Red" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
&nbsp;
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Visible="False" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="QQ" HeaderText="QQ">
                <ControlStyle Width="120px" />
                <HeaderStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="密码" HeaderText="密码">
                <ControlStyle Width="120px" />
                <HeaderStyle Width="150px" />
                <ItemStyle HorizontalAlign="Center" Wrap="False" />
                </asp:BoundField>
                <asp:BoundField DataField="昵称" HeaderText="昵称">
                <ControlStyle BorderStyle="Outset" Width="200px" />
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="段位" HeaderText="段位">
                <HeaderStyle Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="英雄数" HeaderText="英雄数">
                <HeaderStyle Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="皮肤数" HeaderText="皮肤数">
                <HeaderStyle Width="80px" />
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />

        </asp:GridView>
        <br />

    </div>
    
    <script type="text/javascript">
        var prevselitem = null;
        function selectx(row) {
            if (prevselitem != null) {
                prevselitem.style.backgroundColor = '#ffffff';
            }
            row.style.backgroundColor = 'PeachPuff';
            prevselitem = row;
        }
</script>
        <asp:Panel ID="Panel2" runat="server" Height="74px">
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="panel_hd" runat="server" Height="176px">
                        <center>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="最新活动"></asp:Label>
                            <br />
            <br />

                &nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="http://img.dwstatic.com/lol/1711/374890666093/1510935653456.jpg" OnClick="ImageButton1_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="http://img.dwstatic.com/lol/1711/374718293710/1510763301580.jpg" OnClick="ImageButton2_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/xg.png" OnClick="ImageButton3_Click" />
               </center>
            
                    </asp:Panel>
                        
        <br /> 
        <asp:Panel ID="Panel4" runat="server" Visible="False">
                            <!--高速版-->
                            <div id="SOHUCS">
                            </div>
                            <script charset="utf-8" src="http://changyan.sohu.com/upload/changyan.js" type="text/javascript">
</script>
                            <script type="text/javascript">

    window.changyan.api.config({
        appid: 'cytl7BdE9',
        conf: 'prod_562b691ab574a428a9934ba2685308ec'
    });
</script>
        </asp:Panel>


    </form>
    
    
<%--    <div id="Slide1" class="zy-Slide">
	<!--prev:元素中的文本通常会保留空格和换行符。而文本也会呈现为等宽字体。-->
	<section>前一张</section>
	<section>后一张</section>
	<ul>
		<!--alt + shift : 可以创建一个矩形选择区域-->
		<li><a href="https://zhidao.baidu.com/"><img src="images/1.jpg" /></a></li>
		<li><img src="images/2.jpg" /></li>
		<li><img src="images/3.jpg" /></li>

	</ul>
</div>
    <script src="jquery.min.js"></script>
<script src="jquery.zySlide.js"></script>
<script src="index.js"></script>--%>

    </body>
</html>
