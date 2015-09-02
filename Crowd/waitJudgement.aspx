<%@ Page Language="C#" AutoEventWireup="true" CodeFile="waitJudgement.aspx.cs" Inherits="waitJudgement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server"  style="margin-left:200px">
    <div>
        
        <asp:Table ID="Table1" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">任务：请问这是一个简单任务吗？？</asp:TableHeaderCell>
            </asp:TableHeaderRow>
             <asp:TableHeaderRow>
                <asp:TableHeaderCell>工作流ID：</asp:TableHeaderCell>
                  <asp:TableCell>
                    <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="150px" Enabled="false"></asp:TextBox>
                </asp:TableCell>
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
                <asp:TableCell>  
                    <asp:RadioButton ID="RadioButton1"  GroupName="judge" runat="server" Text="yes" TextAlign="Right" />
                    <asp:RadioButton ID="RadioButton2" GroupName="judge" runat="server" Text="no" TextAlign="Right" />
                </asp:TableCell>
                  <asp:TableCell>

                      <asp:Button ID="Button1" runat="server" Text="submit" onclick="Button1_Click"/>
                  </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
