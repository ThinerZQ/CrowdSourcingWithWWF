<%@ Page Language="C#" AutoEventWireup="true" CodeFile="subTaskSolving.aspx.cs" Inherits="subTaskSolving" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="margin-left:200px">
    <div style="margin-top:20px;">
        
        <asp:Table ID="Table1" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">子任务解决</asp:TableHeaderCell>
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

               <asp:TableRow>

                <asp:TableCell>请给出你的解决方案：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="TextBox4" runat="server" Height="200px"  TextMode="MultiLine" Width="400px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

             <asp:TableRow>

                <asp:TableCell ColumnSpan="2">

                    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>

        </div>
        </form>

</body>
</html>
