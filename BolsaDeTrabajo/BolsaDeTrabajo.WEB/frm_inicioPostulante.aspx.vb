Imports BolsaDeTrabajo.AD

Public Class frm_inicioPostulante

    Inherits System.Web.UI.Page

    Dim aviso As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Session("IdPostulante") = 2
        BuscarAvisos()

    End Sub

    Private Sub BuscarAvisos()

        Dim ods As New DataSet
        Dim oAviso As New cAvisos


        ods = oAviso.BuscarAvisos

        aviso = Me.Repeater1.DataMember = "IdAvisoPublicado"
        Me.Repeater1.DataSource = ods.Tables(0)
        Me.Repeater1.DataBind()

    End Sub

    Protected Sub cmb_postularse_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim oAviso As New cAvisos

        oAviso.Postularse(Session("IdPostulante"), aviso)

    End Sub

    Private Sub Repeater1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles Repeater1.ItemDataBound



    End Sub

End Class