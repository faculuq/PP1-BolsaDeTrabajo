<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_DatosContactoEmpresa.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_DatosContactoEmpresa" %>

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
  <li><a href="frm_informacionEmpresa.aspx" ><span>informacionEmpresa</span></a></li>
  <li><a href="frm_datosContactoEmpresa.aspx" ><span>Datos de Contacto Empresa</span></a></li>
  <li><a href="frm_datosEstudio.aspx"><span>Estudios</span></a></li>
  <li><a href="frm_experienciasLaborales.aspx"class="current"><span>Experiencias Laborales</span></a></li>
 </ul><br />
 <div>
     <table style="width:100%;">
         <tr>
             <td>
                 Email</td>
             <td>
                 <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
             </td>
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
                 Pais</td>
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
                 Numero</td>
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
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
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
