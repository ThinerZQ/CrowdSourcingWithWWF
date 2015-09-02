<%@ Page Language="C#" AutoEventWireup="true" CodeFile="subTaskDecomposing.aspx.cs" Inherits="subTaskDecomposing" %>

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
                <asp:TableHeaderCell ColumnSpan="2">子任务分解</asp:TableHeaderCell>
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
                     <asp:TextBox ID="TextBox2" runat="server" Height="100px" Width="200px"  Enabled="false" TextMode="MultiLine"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow> 
              <asp:TableRow>

                <asp:TableCell>工作流ID：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="400px"  Enabled="false"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

              <asp:TableRow>
                <asp:TableCell>  
                    你打算分解成几步？
                </asp:TableCell>
                  <asp:TableCell>
                      <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                  </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
        <asp:Panel Visible="false" runat="server" ID="panel1">
           
            <asp:Table ID="Table2" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">第一步</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>指定任务名称：</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="taskName_1" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow> 
             <asp:TableRow>

                <asp:TableCell>给出任务描述：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="taskDescription_1" runat="server" Height="100px" Width="200px" TextMode="MultiLine"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </asp:Panel>
        <asp:Panel Visible="false" runat="server" ID="panel2">
           
            <asp:Table ID="Table3" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">第二步</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>指定任务名称：</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="taskName_2" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow> 
             <asp:TableRow>

                <asp:TableCell>给出任务描述：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="taskDescription_2" runat="server" Height="100px" Width="200px" TextMode="MultiLine"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </asp:Panel>
       <asp:Panel Visible="false" runat="server" ID="panel3">
           
            <asp:Table ID="Table4" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">第三步</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>指定任务名称：</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="taskName_3" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow> 
             <asp:TableRow>

                <asp:TableCell>给出任务描述：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="taskDescription_3" runat="server" Height="100px" Width="200px" TextMode="MultiLine" ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </asp:Panel>
       <asp:Panel Visible="false" runat="server" ID="panel4">
           
            <asp:Table ID="Table5" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">第四步</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>指定任务名称：</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="taskName_4" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow> 
             <asp:TableRow>

                <asp:TableCell>给出任务描述：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="taskDescription_4"  TextMode="MultiLine" runat="server" Height="100px" Width="200px"  ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </asp:Panel>
       <asp:Panel Visible="false" runat="server" ID="panel5">
           
            <asp:Table ID="Table6" runat="server" style="margin-bottom: 0px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ColumnSpan="2">第五步</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>指定任务名称：</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="taskName_5" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow> 
             <asp:TableRow>

                <asp:TableCell>给出任务描述：</asp:TableCell>
                <asp:TableCell>
                     <asp:TextBox ID="taskDescription_5" runat="server" TextMode="MultiLine" Height="100px" Width="200px" ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </asp:Panel>
       <asp:Button ID="Button1" runat="server" Text="确认" onclick="Button1_Click" Visible="False"/>



       <asp:TextBox ID="tb_step" runat="server" Visible="false"></asp:TextBox>



    </form>

   
       

   



</body>
</html>
