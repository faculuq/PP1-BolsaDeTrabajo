<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_Login.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 96px;
            height: 23px;
        }
        .style3
        {
            height: 23px;
        }
        .style4
        {
            height: 23px;
            width: 165px;
        }
        .style5
        {
            width: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style2">
                    Usuario</td>
                <td class="style4">
                    <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
                </td>
                <td class="style3">
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Contrasena</td>
                <td class="style5">
                    <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Button ID="cmb_inicio" runat="server" Text="Iniciar Sesion" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                <a href= "frm_RegistroPostulante">Registrarse.</a>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                <a href= "frm_RegistroEmpresa">Registrarse como Empresa.</a>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
