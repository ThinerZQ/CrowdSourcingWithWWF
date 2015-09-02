<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewTask.aspx.cs" Inherits="viewTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
        <div runat="server"  style="margin-left:200px">

            <span>------------------------------------------------------------------------------</span>
         <asp:Table runat="server" ID="mainTaskTable">

             <asp:TableHeaderRow>
                 <asp:TableHeaderCell>主任务</asp:TableHeaderCell>
             </asp:TableHeaderRow>
         </asp:Table>
         <span>------------------------------------------------------------------------------</span>
             <asp:Table runat="server" ID="decomposeTable">

             <asp:TableHeaderRow>
                 <asp:TableHeaderCell>分解任务</asp:TableHeaderCell>
             </asp:TableHeaderRow>
         </asp:Table>
             <span>------------------------------------------------------------------------------</span>
             <asp:Table runat="server" ID="decomposeVotingTable">
             <asp:TableHeaderRow>
                 <asp:TableHeaderCell>分解投票任务</asp:TableHeaderCell>
             </asp:TableHeaderRow>
         </asp:Table>

              <span>------------------------------------------------------------------------------</span>
             <asp:Table runat="server" ID="solveTable">
             <asp:TableHeaderRow>
                 <asp:TableHeaderCell>解决任务</asp:TableHeaderCell>
             </asp:TableHeaderRow>
         </asp:Table>

               <span>------------------------------------------------------------------------------</span>
             <asp:Table runat="server" ID="solveVotingTable">
             <asp:TableHeaderRow>
                 <asp:TableHeaderCell>解决投票任务</asp:TableHeaderCell>
             </asp:TableHeaderRow>
         </asp:Table>
            <span>------------------------------------------------------------------------------</span>
            

        </div>
</body>
</html>
