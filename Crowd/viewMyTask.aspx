<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewMyTask.aspx.cs" Inherits="viewMyTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server"  style="margin-left:200px">
         <a href="Login.aspx">登录</a>
         <a href="viewTask.aspx">浏览任务</a>
    <div style="margin-top:20px;">
        
        <asp:Table ID="Table1" runat="server">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">我的发布</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>任务名称：</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px" Enabled="false"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow> 
             <asp:TableRow>

                <asp:TableCell>任务描述：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="TextBox2" runat="server" Height="100px" Width="200px"  Enabled="false"></asp:TextBox>
                </asp:TableCell>

            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell>工作流ID：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="200px"  Enabled="false"></asp:TextBox>
                </asp:TableCell>
                  </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell ColumnSpan="2">  
                    <asp:Button ID="Button1" runat="server" Text="查看结果" OnClick="Button1_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>


       <asp:Panel Visible="false" ID="answerPanel" runat="server">
           <asp:TextBox ID="answerTextBox" runat="server" Enabled="False" Height="600px" Width="600px" TextMode="MultiLine"></asp:TextBox>
           kkkkk</asp:Panel>
    </form>
</body>
</html>
