Public Class frm_inicioPostulante
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lbl_user.Text = Session("IdUsuario")
        lbl_poss.Text = Session("IdPostulante")

    End Sub

End Class