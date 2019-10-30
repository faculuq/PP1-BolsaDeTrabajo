<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_datosEstudioEditar.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_datosEstudioEditar" %>

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
            width: 195px;
        }
        .style2
        {
            width: 194px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <ul id="saturday">
  <li><a href="frm_datosPersonalesEditarP.aspx" ><span>Datos Personales</span></a></li>
  <li><a href="frm_datosContactoEditarP.aspx" ><span>Datos de Contacto</span></a></li>
  <li><a href="frm_datosEstudioEditar.aspx"class="current"><span>Estudios</span></a></li>
  <li><a href="frm_experienciasLaboralesEditar.aspx"><span>Experiencias Laborales</span></a></li>
  <li> <a href="frm_inicioPostulante.aspx">Regresar al Inicio.</a></li>
 </ul><br />
 <div>
     <table style="width:100%;">
         <tr>
             <td class="style1">
                 Nivel de Estudio</td>
             <td class="style2">
                 <asp:DropDownList ID="cbo_nivelEstudio" runat="server" Height="16px" 
                     Width="128px">
                 </asp:DropDownList>
             </td>
             <td>
                 Estado</td>
             <td>
                 <asp:DropDownList ID="cbo_estadoEstudio" runat="server" Height="16px" 
                     Width="128px">
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td class="style1">
                 Titulo</td>
             <td class="style2">
                 <asp:TextBox ID="txt_titulo" runat="server"></asp:TextBox>
             </td>
             <td>
                 Area de Estudio</td>
             <td>
                 <asp:DropDownList ID="cbo_areaEstudio" runat="server" Height="16px" 
                     Width="128px">
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td class="style1">
                 Institucion</td>
             <td class="style2">
                 <asp:TextBox ID="txt_institucion" runat="server"></asp:TextBox>
             </td>
             <td>
                 Fecha de Inicio</td>
             <td>
                 <asp:TextBox ID="txt_fechaInicio" runat="server" TextMode="Date"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td class="style1">
                 Fecha de Fin</td>
             <td class="style2">
                 <asp:TextBox ID="txt_FechaFin" runat="server" TextMode="Date"></asp:TextBox>
             </td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 &nbsp;</td>
             <td class="style2">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 <asp:Button ID="cmb_cargar" runat="server" Text="Guardar Cambios" />
             </td>
             <td class="style2">
                 <asp:Button ID="cmb_editar" runat="server" Text="Editar Informacion" />
             </td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 &nbsp;</td>
             <td class="style2">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 &nbsp;</td>
             <td class="style2">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 &nbsp;</td>
             <td class="style2">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style1">
                 &nbsp;</td>
             <td class="style2">
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