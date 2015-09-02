<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deployTask.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server"  style="margin-left:200px">
    <div>
        <asp:TextBox ID="TextBox3" runat="server">fgh</asp:TextBox>
        <asp:Table ID="Table1" runat="server">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">发布任务</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>任务名称：</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>

                <asp:TableCell>任务描述：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="TextBox2" runat="server" Height="100px" Width="200px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
              <asp:TableRow>
                <asp:TableCell ColumnSpan="2">  
                    <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
                </asp:TableCell>
              
            </asp:TableRow>

        </asp:Table>
          <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
