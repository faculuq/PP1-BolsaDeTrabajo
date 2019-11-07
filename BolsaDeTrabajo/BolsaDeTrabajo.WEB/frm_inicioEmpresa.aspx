<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_inicioEmpresa.aspx.vb" Inherits="BolsaDeTrabajo.WEB.frm_inicioEmpresa" %>

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
   <li><a href="frm_inicioEmpresa.aspx"class="current" ><span>Inicio</span></a></li>
  <li><a href="frm_InformacionEmpresaEditar.aspx" ><span>Editar Informacion</span></a></li>
  <li><a href="frm_MisAvisos.aspx"><span>Mis Avisos</span></a></li>
   <li><a href="frm_crearAvisos.aspx"><span>Crear Aviso</span></a></li>
       
            </li>

 </ul><br />
 <div>
     <asp:Repeater ID="Repeater1" runat="server">
     <ItemTemplate>
               <div >
                   
                   <asp:Panel ID="Panel1" runat="server">
                       <asp:Label ID="lbl1" Text="Nombre Empresa: " runat="server"></asp:Label><asp:Label ID="lbl_empresa" Text="" runat="server"></asp:Label>
                   <asp:Label ID="Label1" Text='<% #Eval("Nombre") %>' runat="server"></asp:Label><br />
                   <asp:Label ID="lbl2" Text="Puesto: " runat="server"></asp:Label><asp:Label ID="lbl_descripcion" Text="" runat="server"></asp:Label>
                   <asp:Label ID="Label2" Text='<% #Eval("Descripcion") %>' runat="server"></asp:Label><br />
                   <asp:Label ID="lbl3" Text="Requerimentos: " runat="server"></asp:Label><asp:Label ID="lbl_requerimentos" Text="" runat="server"></asp:Label>
                   <asp:Label ID="Label3" Text='<% #Eval("Requisitos") %>' runat="server"></asp:Label><br />
                       
                   </asp:Panel>
                   
                       <br /><br />
               </div>
           </ItemTemplate>
     </asp:Repeater>
    </div>
    
    </form>
</body>
</html>
