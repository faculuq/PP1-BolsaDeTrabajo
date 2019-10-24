Imports BolsaDeTrabajo.AD

Public Class frm_InformacionEmpresa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub



    Private Sub cmd_GuardarDatos_Click(sender As Object, e As EventArgs) Handles cmd_GuardarDatos.Click
        Dim oEmpresas As New cEmpresas

        If txt_Nombre.Text <> Nothing And txt_RazonSocial.Text <> Nothing And cbo_tipoDoc.SelectedValue <> Nothing And txt_numeroDoc.Text <> Nothing And txt_Fundacion.Text <> Nothing And TextBox.Text <> Nothing Then
            oEmpresas.EmpresaGuardarInformacion(Session("IdUsuario"), txt_nombre.Text, txt_RazonSocial.Text, cbo_tipoDoc.SelectedValue, txt_numeroDoc.Text, txt_Fundacion.Text, cbo_IdRubro.Text)
            Response.Redirect("frm_datosContactoEmpresa.aspx")
            MsgBox("Datos agregados correctamente", vbInformation, "Datos Personales")
        Else
            MsgBox("Complete todos los campos para continuar", vbInformation, "Datos Personales")
        End If
    End Sub
End Class