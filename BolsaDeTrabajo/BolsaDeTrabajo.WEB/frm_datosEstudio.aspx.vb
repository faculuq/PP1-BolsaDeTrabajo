Imports BolsaDeTrabajo.AD

Public Class frm_datosEstudio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CargarAreasEstudios()
        CargarEstadosEstudios()
        CargarNivelesEstudios()


    End Sub

    Protected Sub cmb_cargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_cargar.Click

        Dim oEstudio As New cEstudios

        If txt_FechaFin.Text <> Nothing And txt_fechaInicio.Text <> Nothing And txt_institucion.Text <> Nothing And txt_titulo.Text <> Nothing Then

            oEstudio.AgregarDatos(Session("IdPostulante"), cbo_nivelEstudio.SelectedValue, cbo_estadoEstudio.SelectedValue, txt_titulo.Text, cbo_areaEstudio.SelectedValue, txt_institucion.Text, txt_fechaInicio.Text, txt_FechaFin.Text)
            MsgBox("Datos actualizados correctamente", vbInformation, "Estudios")
            Response.Redirect("frm_experienciasLaborales.aspx", Session("IdPostulante"))

        Else

            MsgBox("Completar todos los campos para continuar", vbInformation, "Estudios")

        End If

    End Sub

    Private Sub CargarEstadosEstudios()

        Dim ods As New DataSet
        Dim OEstadoEstudio As New cEstadosEstudios

        ods = OEstadoEstudio.BuscarTodos
        cbo_estadoEstudio.DataSource = ods.Tables(0)
        cbo_estadoEstudio.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_estadoEstudio.DataValueField = ods.Tables(0).Columns("IdEstadoEstudio").ToString
        cbo_estadoEstudio.DataBind()

    End Sub

    Private Sub CargarNivelesEstudios()

        Dim ods As New DataSet
        Dim ONivelEstudio As New cNivelesEstudios

        ods = ONivelEstudio.BuscarTodos
        cbo_nivelEstudio.DataSource = ods.Tables(0)
        cbo_nivelEstudio.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_nivelEstudio.DataValueField = ods.Tables(0).Columns("IdNivelEstudio").ToString
        cbo_nivelEstudio.DataBind()

    End Sub


    Private Sub CargarAreasEstudios()

        Dim ods As New DataSet
        Dim OAreaEstudio As New cAreasEstudio

        ods = OAreaEstudio.BuscarTodos
        cbo_areaEstudio.DataSource = ods.Tables(0)
        cbo_areaEstudio.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_areaEstudio.DataValueField = ods.Tables(0).Columns("IdAreaEstudio").ToString
        cbo_areaEstudio.DataBind()

    End Sub

End Class