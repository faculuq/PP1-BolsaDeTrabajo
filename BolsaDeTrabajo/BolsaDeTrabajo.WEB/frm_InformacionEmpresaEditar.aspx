﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_InformacionEmpresaEditar.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_InformacionEmpresaEditar" %>

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
        .style3
        {
            width: 197px;
        }
        .style4
        {
            width: 260px;
        }
        .style5
        {
            width: 173px;
            height: 26px;
        }
        .style6
        {
            width: 197px;
            height: 26px;
        }
        .style8
        {
            width: 260px;
            height: 26px;
        }
        .style9
        {
            height: 26px;
        }
        .style10
        {
            width: 173px;
            height: 25px;
        }
        .style11
        {
            width: 197px;
            height: 25px;
        }
        .style13
        {
            width: 260px;
            height: 25px;
        }
        .style14
        {
            height: 25px;
        }
    </style>
    <script language="javascript" type="text/javascript">
// <![CDATA[

    
// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
   <ul id="saturday">
  <li><a href="frm_informacionEmpresaEditar.aspx"class="current" ><span>Información Empresa</span></a></li>
  <li><a href="frm_datosContactoEmpresaEditar.aspx" ><span>Datos de Contacto Empresa</span></a></li>
  <li><a href="frm_inicioEmpresa.aspx" ><span>Regresar al Inicio</span></a></li>
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
                 Razón Social</td>
          <td class="style1">
                 Razón Social</td>

             <td class="style4">
                 <asp:TextBox ID="txt_RazonSocial" runat="server"></asp:TextBox>
             </td>
             <td>
                 &nbsp;</td>
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
     <td class="style1">
                 Numero de Documento</td>

             <td class="style4">
                 <asp:TextBox ID="txt_numeroDoc" runat="server"></asp:TextBox>
             </td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 Fecha Fundación </td>
             <td class="style3">
                 <asp:TextBox ID="txt_Fundacion" runat="server" TextMode="Date"></asp:TextBox>
             </td>
             <td class="style1">
     Rubro </td>
             <td class="style4" id="lt_IdRubro">
                 <asp:DropDownList ID="cbo_IdRubro" runat="server">
                 </asp:DropDownList>
             </td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style5">
                 </td>
             <td class="style6">
             </td>
             <td class="style5">
                 &nbsp;</td>
             <td class="style8">
                 &nbsp;</td>
             <td class="style9">
                 </td>
         </tr>
         <tr>
             <td class="style1">
                 <asp:Button ID="cmd_GuardarDatos" runat="server" Text="Guardar Cambios" />
             </td>
             <td class="style3">
                 <asp:Button ID="cmdEditarInformacion" runat="server" Text="Editar Informacion" 
                     Width="141px" />
             <td class="style1">
                 &nbsp;</td>
             <td class="style4">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style5">
                 </td>
             <td class="style6">
                 </td>
             <td class="style5">
                 </td>
             <td class="style8">
                 </td>
             <td class="style9">
                 </td>
         </tr>
         <tr>
             <td class="style10">
             </td>
             <td class="style11">
                 </td>
             <td class="style10">
                 </td>
             <td class="style13">
                 </td>
             <td class="style14">
                 </td>
         </tr>
         <tr>
             <td class="style1">
                 &nbsp;</td>
             <td class="style3">
                 &nbsp;</td>
             <td class="style1">
                 &nbsp;</td>
             <td class="style4">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
     </table>
    </div>
    </form>
</body>
</html>