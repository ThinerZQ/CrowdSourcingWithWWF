<%@ Page Language="C#" AutoEventWireup="true" CodeFile="subTaskSolveVoting.aspx.cs" Inherits="subTaskSolveVoting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    
    <body>
    <form id="form1" runat="server"  style="margin-left:300px">
    <div>
                <span>请选择出最好的解决方案？</span>

     
            <hr /> <br /> <br /> <br />

        <asp:Table ID="Table1" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">任务内容</asp:TableHeaderCell>
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
             
                  </asp:Table>
                   <hr /> <br /> <br /> <br />


        <asp:Panel runat="server" ID="panel"></asp:Panel>
    </div>


        <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>

    </form>
</body>
</html>
