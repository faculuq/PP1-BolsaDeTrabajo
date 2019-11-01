Imports BolsaDeTrabajo.AD

Public Class frm_inicioPostulante
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        BuscarAvisos()
    End Sub

    Private Sub BuscarAvisos()

        Dim ods As New DataSet
        Dim oAviso As New cavisos

        ods = oAviso.BuscarAvisos

        Me.Repeater1.DataMember = "IdAvisoPublicado"
        Me.Repeater1.DataSource = ods
        Me.Repeater1.DataBind()

    End Sub

End Class