﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_DatosContactoEmpresaEditar.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_DatosContactoEmpresaEditar" %>

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
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <ul id="saturday">
  <li><a href="frm_informacionEmpresaEditar.aspx" ><span>Informacion Empresa</span></a></li>
  <li><a href="frm_datosContactoEmpresaEditar.aspx" class="current"><span>Datos de Contacto Empresa</span></a></li>
 <li><a href="frm_inicioEmpresa.aspx" ><span>Regresar al Inicio</span></a></li>

 </ul><br />
 <div>
     <table style="width:100%;">
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td>
                 Telefono Fijo</td>
             <td>
                 <asp:TextBox ID="txt_telFijo" runat="server"></asp:TextBox>
             </td>
             <td>
                 País</td>
             <td>
                 <asp:DropDownList ID="cbo_pais" runat="server" Height="16px" Width="128px">
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td>
                 Provincia</td>
             <td>
                 <asp:DropDownList ID="cbo_provincia" runat="server" Height="16px" Width="128px">
                 </asp:DropDownList>
             </td>
             <td>
                 Departamento</td>
             <td>
                 <asp:DropDownList ID="cbo_depto" runat="server" Height="16px" Width="128px">
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td>
                 Localidad</td>
             <td>
                 <asp:DropDownList ID="cbo_localidad" runat="server" Height="16px" Width="128px">
                 </asp:DropDownList>
             </td>
             <td rowspan "2">
                 Calle</td>
             <td>
                 <asp:TextBox ID="txt_calle" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 Número</td>
             <td>
                 <asp:TextBox ID="txt_numero" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td>
                 <asp:Button ID="cmb_cargarE" runat="server" Text="Guardar Cambios" />
             </td>
             <td>
                 <asp:Button ID="cmdEditarInformacion" runat="server" 
                     Text="Editar Informacion" />
             </td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 </td>
             <td class="style1">
                 </td>
             <td class="style1">
                 </td>
             <td class="style1">
                 </td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
     </table>
    </div>
 </form>
</body>
</html>

