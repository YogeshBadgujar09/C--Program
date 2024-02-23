<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 562px;
        }
        .style3
        {
            height: 23px;
            width: 241px;
        }
        .style4
        {
            width: 562px;
            height: 23px;
        }
        .style5
        {
            width: 241px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 53%;">
            <tr>
                <td class="style5">
                    <asp:Label ID="Label1" runat="server" Text="Enter  First Number    : "></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtNo1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label2" runat="server" Text="Enter Second Number  :"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtNo2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                    <asp:Button ID="btnOp" runat="server" onclick="btnOp_Click" Text="Operation" />
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label3" runat="server" Text="ADDITION"></asp:Label>
                </td>
                <td class="style2">
                    <asp:Label ID="Label4" runat="server" Text="SUBSTRACTION"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtSub" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label5" runat="server" Text="MULTIPLICATION"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="Label6" runat="server" Text="DIVISION"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:TextBox ID="txtMul" runat="server"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtDiv" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
