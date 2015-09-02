<%@ Page Language="C#" AutoEventWireup="true" CodeFile="subTaskDecomposeVoting.aspx.cs" Inherits="subTaskDecomposeVoting" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server"  style="margin-left:300px">
    <div>
                <span>请选择出哪一种方案是最好的分解方案？</span>


         <asp:Table ID="Table1" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">子任务分解投票</asp:TableHeaderCell>
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
                     <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="400px"  Enabled="false"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

             </asp:Table>


        <br /> <br /> <br /> <br />
            <hr /> <br /> <br /> <br />
        <asp:Panel runat="server" ID="panel"></asp:Panel>
    </div>


        <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>

    </form>
</body>
</html>
