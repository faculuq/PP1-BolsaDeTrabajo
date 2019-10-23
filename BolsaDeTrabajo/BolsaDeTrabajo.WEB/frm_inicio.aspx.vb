Public Class frm_inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_nombre.Text = Session("IdUsuario")
    End Sub

End Class