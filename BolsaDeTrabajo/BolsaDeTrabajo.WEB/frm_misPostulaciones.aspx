<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_misPostulaciones.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_misPostulaciones" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Bolsa de Trabajo</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" href="styles.css" type="text/css" />
  <link rel="icon" href="jobs_craiglist_icon-icons.com_51083.ico">
    </head>
<body>
    <form id="form1" runat="server">
    <ul id="saturday">
   <li><a href="frm_inicioPostulante.aspx" ><span>Inicio</span></a></li>
  <li><a href="frm_datosPersonalesEditarP.aspx" ><span>Editar Informacion</span></a></li>
  <li><span><a href="frm_datosEstudioEditar.aspx"class="current">Mis Postulaciones</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp;&nbsp; </li>
        <li>
            <asp:TextBox ID="txt_busqueda" runat="server" Height="22px" Width="162px"></asp:TextBox>
        </li>
 </ul><br />
    </form>
</body>
</html>

