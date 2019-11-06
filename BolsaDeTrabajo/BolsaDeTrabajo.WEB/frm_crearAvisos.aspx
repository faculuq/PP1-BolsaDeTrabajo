<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_crearAvisos.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_crearAvisos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Bolsa de Trabajo</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" href="styles.css" type="text/css" />
  <link rel="icon" href="jobs_craiglist_icon-icons.com_51083.ico">
    <style type="text/css">
        .style1
        {
            width: 172px;
        }
        .style2
        {
            width: 232px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <ul id="saturday">
    <li><a href="frm_inicioEmpresa.aspx" ><span>Inicio</span></a></li>
  <li><a href="frm_InformacionEmpresaEditar.aspx" ><span>Editar Informacion</span></a></li>
  <li><a href="frm_MisAvisos.aspx" ><span>Mis Avisos</span></a></li>
   <li><a href="frm_crearAvisos.aspx"class="current"><span>Crear Aviso</span></a></li>
      </ul><br /> 

      <div>
          <table style="width:100%;">
              <tr>
                  <td class="style1">
                      Puesto Ofrecido</td>
                  <td>
                      <asp:TextBox ID="txt_puesto" runat="server" style="margin-left: 0px"></asp:TextBox>
                  </td>
                  <td class="style2">
                      Requisitos del Puesto</td>
                  <td>
                      <asp:TextBox ID="txt_requisitos" runat="server" style="margin-left: 0px"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="style1">
                      Palabra Clave 1</td>
                  <td>
                      <asp:TextBox ID="txt_palabra1" runat="server" style="margin-left: 0px"></asp:TextBox>
                  </td>
                  <td class="style2">
                      Palabra Clave 2</td>
                  <td>
                      <asp:TextBox ID="txt_palabra2" runat="server" style="margin-left: 0px"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="style1">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
                  <td class="style2">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style1">
                      <asp:Button ID="cmb_publicar" runat="server" Text="Publicar Aviso" />
                  </td>
                  <td>
                      &nbsp;</td>
                  <td class="style2">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style1">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
                  <td class="style2">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style1">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
                  <td class="style2">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style1">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
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

