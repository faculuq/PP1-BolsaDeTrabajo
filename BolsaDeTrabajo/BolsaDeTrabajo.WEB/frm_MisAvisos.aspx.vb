Imports BolsaDeTrabajo.AD

Public Class frm_MisAvisos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then



            BuscarAvisos()
        End If
    End Sub

    Private Sub BuscarAvisos()

        Dim ods As New DataSet
        Dim oAviso As New cAvisos


        ods = oAviso.BuscarPorEmpresa(Session("IdEmpresa"))

        Me.Repeater1.DataMember = "IdAvisoPublicado"
        Me.Repeater1.DataSource = ods.Tables(0)
        Me.Repeater1.DataBind()

    End Sub

End Class