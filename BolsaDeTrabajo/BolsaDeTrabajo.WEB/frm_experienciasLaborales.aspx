<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_experienciasLaborales.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_experienciasLaborales" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Bolsa de Trabajo</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" href="styles.css" type="text/css" />
    <link rel="icon" href="jobs_craiglist_icon-icons.com_51083.ico">
    <style type="text/css">
        #TextArea1
        {
            width: 434px;
            height: 65px;
        }
        #txt_descripcion
        {
            width: 380px;
            height: 61px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <ul id="saturday">
  <li><a href="frm_datosPersonales.aspx" ><span>Datos Personales</span></a></li>
  <li><a href="frm_datosContacto.aspx" ><span>Datos de Contacto</span></a></li>
  <li><a href="frm_datosEstudio.aspx"><span>Estudios</span></a></li>
  <li><a href="frm_experienciasLaborales.aspx"class="current"><span>Experiencias Laborales</span></a></li>
 </ul><br />
 <div>
     <table style="width:100%;">
         <tr>
             <td>
                 Area Laboral</td>
             <td>
                 <asp:DropDownList ID="cbo_areaLaboral" runat="server" Height="16px" 
                     Width="128px" AutoPostBack="True">
                 </asp:DropDownList>
             </td>
             <td>
                 Puesto</td>
             <td>
                 <asp:DropDownList ID="cbo_puestoLaboral" runat="server" Height="16px" 
                     Width="128px" AutoPostBack="True">
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td>
                 Rubro de la Empresa</td>
             <td>
                 <asp:DropDownList ID="cbo_rubroEmp" runat="server" Height="16px" 
                     Width="128px">
                 </asp:DropDownList>
             </td>
             <td>
                 Nombre</td>
             <td>
                 <asp:TextBox ID="txt_nombreEmpresa" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 Descripcion de Responsabilidades</td>
             <td colspan="3">
                 <asp:TextBox ID="txt_descripcion" runat="server" Height="53px" Width="325px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 Fecha de Inicio</td>
             <td>
                 <asp:TextBox ID="txt_fechaInicio" runat="server" TextMode="Date"></asp:TextBox>
             </td>
             <td>
                 Fecha de Fin</td>
             <td>
                 <asp:TextBox ID="txt_fechaFin" runat="server" TextMode="Date"></asp:TextBox>
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
                 <asp:Button ID="cmb_cargar" runat="server" Text="Guardar Cambios" />
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