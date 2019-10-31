<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_inicioPostulante.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_inicioPostulante" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbl_user" runat="server" Text="Label"></asp:Label>
&nbsp;
        <asp:Label ID="lbl_poss" runat="server" Text="Label"></asp:Label>
    
    </div>
    <asp:Repeater ID="Repeater1" runat="server">
    </asp:Repeater>
    </form>
</body>
</html>
