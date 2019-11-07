<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_experienciasLaboralesEditar.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_experienciasLaboralesEditar" %>

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
        .style1
        {
            width: 191px;
        }
        .style2
        {
            width: 225px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <ul id="saturday">
  <li><a href="frm_datosPersonalesEditarP.aspx" ><span>Datos Personales</span></a></li>
  <li><a href="frm_datosContactoEditarP.aspx" ><span>Datos de Contacto</span></a></li>
  <li><a href="frm_datosEstudioEditar.aspx"><span>Estudios</span></a></li>
  <li><a href="frm_experienciasLaboralesEditar.aspx"class="current"><span>Experiencias Laborales</span></a></li>
  <li> <a href="frm_inicioPostulante.aspx">Regresar al Inicio.</a></li>
  </ul><br />
 <div>
     <table style="width:100%;">
         <tr>
             <td class="style2">
                 Área Laboral</td>
             <td class="style1">
                 <asp:DropDownList ID="cbo_areaLaboral" runat="server" Height="16px" 
                     Width="128px">
                 </asp:DropDownList>
             </td>
             <td>
                 Puesto</td>
             <td>
                 <asp:DropDownList ID="cbo_puestoLaboral" runat="server" Height="16px" 
                     Width="128px">
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td class="style2">
                 Rubro de la Empresa</td>
             <td class="style1">
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
             <td class="style2">
                 Descripcion de Responsabilidades</td>
             <td colspan="3">
                 <asp:TextBox ID="txt_descripcion" runat="server" Height="53px" Width="325px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td class="style2">
                 Fecha de Inicio</td>
             <td class="style1">
                 <asp:TextBox ID="txt_fechaInicio" runat="server"></asp:TextBox>
             </td>
             <td>
                 Fecha de Fin</td>
             <td>
                 <asp:TextBox ID="txt_fechaFin" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td class="style2">
                 &nbsp;</td>
             <td class="style1">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style2">
                 <asp:Button ID="cmb_cargar" runat="server" Text="Guardar Cambios" />
             </td>
             <td class="style1">
                 <asp:Button ID="cmb_editar" runat="server" Text="Editar Informacion" />
             </td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style2">
                 &nbsp;</td>
             <td class="style1">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style2">
                 &nbsp;</td>
             <td class="style1">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style2">
                 &nbsp;</td>
             <td class="style1">
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
