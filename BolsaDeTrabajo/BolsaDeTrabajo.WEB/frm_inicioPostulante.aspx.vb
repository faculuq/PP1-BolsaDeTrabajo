Imports BolsaDeTrabajo.AD

Public Class frm_inicioPostulante

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        BuscarAvisos()

    End Sub

    Private Sub BuscarAvisos()

        Dim ods As New DataSet
        Dim oAviso As New cAvisos


        ods = oAviso.BuscarAvisos

        Me.Repeater1.DataMember = "IdAvisoPublicado"
        Me.Repeater1.DataSource = ods.Tables(0)
        Me.Repeater1.DataBind()

    End Sub


    Protected Sub cmb_buscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_buscar.Click

        If txt_busqueda.Text <> Nothing Then

            Dim ods As New DataSet
            Dim oAviso As New cAvisos

            ods = oAviso.BuscarPorPalabraClave(txt_busqueda.Text)

            Me.Repeater1.DataMember = "IdAvisoPublicado"
            Me.Repeater1.DataSource = ods.Tables(0)
            Me.Repeater1.DataBind()

        End If

    End Sub

End Class