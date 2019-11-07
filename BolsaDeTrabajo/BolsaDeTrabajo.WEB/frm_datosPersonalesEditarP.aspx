<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_datosPersonalesEditarP.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_editarDatosPersonalesP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Bolsa de Trabajo</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" href="styles.css" type="text/css" />
  <link rel="icon" href="jobs_craiglist_icon-icons.com_51083.ico">
    <style type="text/css">
        .style1
        {
            width: 173px;
        }
        .style2
        {
            width: 152px;
        }
        .style3
        {
            width: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <ul id="saturday">
   <li><a href="frm_datosPersonalesEditarP.aspx"class="current" ><span>Datos Personales</span></a></li>
  <li><a href="frm_datosContactoEditarP.aspx" ><span>Datos de Contacto</span></a></li>
  <li><a href="frm_datosEstudioEditar.aspx"><span>Estudios</span></a></li>
  <li><a href="frm_experienciasLaboralesEditar.aspx"><span>Experiencias Laborales</span></a></li>
 <li> <a href="frm_inicioPostulante.aspx">Regresar al Inicio.</a></li>
 </ul><br />
 <div>
     <table style="width:100%;">
         <tr>
             <td class="style1">
                 Nombre/s</td>
             <td class="style3">
                 <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
             </td>
             <td class="style2">
                 Apellido/s</td>
             <td>
                 <asp:TextBox ID="txt_apellido" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td class="style1">
                 Tipo de Documento</td>
             <td class="style3">
                 <asp:DropDownList ID="cbo_tipoDoc" runat="server" Height="16px" Width="128px">
                 </asp:DropDownList>
             </td>
             <td class="style2">
                 Número de Documento</td>
             <td>
                 <asp:TextBox ID="txt_numeroDoc" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td class="style1">
                 Estado Civil</td>
             <td class="style3">
                 <asp:DropDownList ID="cbo_estadoCivil" runat="server" Height="16px" 
                     Width="128px">
                 </asp:DropDownList>
             </td>
             <td class="style2">
                 Situación Laboral</td>
             <td>
                 <asp:DropDownList ID="cbo_sitLaboral" runat="server" Height="16px" 
                     Width="128px">
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td class="style1">
                 Fecha de Nacimiento</td>
             <td class="style3">
                 <asp:TextBox ID="txt_fechaNac"  runat="server"></asp:TextBox>
             </td>
             <td class="style2">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 &nbsp;</td>
             <td class="style3">
                 &nbsp;</td>
             <td class="style2">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 &nbsp;</td>
             <td class="style3">
                 &nbsp;</td>
             <td class="style2">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 <asp:Button ID="cmb_cargar" runat="server" Text="Guardar Cambios" />
             </td>
             <td class="style3">
                 <asp:Button ID="cmb_editar" runat="server" Text="Editar Informacion" />
             </td>
             <td class="style2">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
     </table>
    </div>
    </form>
</body>
</html>
