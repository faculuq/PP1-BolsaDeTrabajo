Imports BolsaDeTrabajo.AD

Public Class frm_datosContactoEmpresa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmb_cargarE_Click(sender As Object, e As EventArgs) Handles cmb_cargarE.Click
        Dim oEmpresas As New cEmpresas



        If txt_telFijo.Text <> Nothing And cbo_pais.Text <> Nothing And cbo_provincia.SelectedValue <> Nothing And cbo_localidad.SelectedValue <> Nothing And cbo_depto.SelectedValue <> Nothing And txt_calle.Text <> Nothing And txt_numero.Text <> Nothing Then
            oEmpresas.EmpresaGuardarDatos(Session("IdUsuario"), txt_telFijo.Text, cbo_pais.SelectedValue, cbo_provincia.SelectedValue, cbo_localidad.SelectedValue, cbo_depto.SelectedValue, txt_calle.Text, txt_numero.Text)
            MsgBox("Datos agregados correctamente", vbInformation, "Datos Personales")
        Else
            MsgBox("Complete todos los campos para continuar", vbInformation, "Datos Personales")
        End If
    End Sub
End Class