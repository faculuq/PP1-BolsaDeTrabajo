Imports BolsaDeTrabajo.AD

Public Class frm_crearAvisos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmb_publicar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_publicar.Click

        If txt_puesto.Text <> Nothing And txt_requisitos.Text <> Nothing Then
            If txt_palabra1.Text <> Nothing Or txt_palabra2.Text <> Nothing Then

                Dim ods As New DataSet
                Dim oAviso As New cAvisos

                oAviso.Agregar(Session("IdEmpresa"), txt_puesto.Text, txt_requisitos.Text, txt_palabra1.Text, txt_palabra2.Text)
                Limpiar()

            Else

                MsgBox("Completar datos para Publicar", vbExclamation, "Bolsa de Trabajo")

            End If

        Else

            MsgBox("Completar datos para Publicar", vbExclamation, "Bolsa de Trabajo")

        End If

    End Sub

    Private Sub Limpiar()

        txt_palabra1.Text = Nothing
        txt_palabra2.Text = Nothing
        txt_puesto.Text = Nothing
        txt_requisitos.Text = Nothing

    End Sub

End Class