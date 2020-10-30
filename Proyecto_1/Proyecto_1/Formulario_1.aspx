<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario_1.aspx.cs" Inherits="Proyecto_1.Formulario_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
            width: 60px;
        }
        .auto-style5 {
            width: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Lbl1" runat="server" Text="Número1"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text1" runat="server" style="margin-left: 96px" Width="123px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Lbl2" runat="server" Text="Número2"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text2" runat="server" Width="118px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Lblresultado" runat="server" Text="Resultado"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Lblresult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style2">
                        <asp:Button ID="Btnboton" runat="server" OnClick="Btnboton_Click" Text="Proceso" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
