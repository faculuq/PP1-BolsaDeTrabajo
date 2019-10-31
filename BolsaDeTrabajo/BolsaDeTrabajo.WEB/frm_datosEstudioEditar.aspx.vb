Imports BolsaDeTrabajo.AD

Public Class frm_datosEstudioEditar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            Inicio()

        End If

    End Sub

    Protected Sub cmb_cargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_cargar.Click

        Dim oEstudio As New cEstudios

        If txt_FechaFin.Text <> Nothing And txt_fechaInicio.Text <> Nothing And txt_institucion.Text <> Nothing And txt_titulo.Text <> Nothing Then

            oEstudio.AgregarDatos(Session("IdPostulante"), cbo_nivelEstudio.SelectedValue, cbo_estadoEstudio.SelectedValue, txt_titulo.Text, cbo_areaEstudio.SelectedValue, txt_institucion.Text, txt_fechaInicio.Text, txt_FechaFin.Text)
            DeshabilitarEdicion()

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


    Private Sub CargarDatos()

        Dim ods As New DataSet
        Dim oEstudio As New cEstudios

        ods = oEstudio.BuscarPorPostulante(Session("IdPostulante"))

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_nivelEstudio.SelectedValue = (ods.Tables(0).Rows(0).Item("IdNivelEstudio"))
            cbo_estadoEstudio.Text = (ods.Tables(0).Rows(0).Item("IdEstadoEstudio"))
            txt_titulo.Text = (ods.Tables(0).Rows(0).Item("Titulo"))
            cbo_areaEstudio.Text = (ods.Tables(0).Rows(0).Item("IdAreaEstudio"))
            txt_institucion.Text = (ods.Tables(0).Rows(0).Item("Institucion"))
            txt_fechaInicio.Text = (ods.Tables(0).Rows(0).Item("FechaInicio"))
            txt_FechaFin.Text = (ods.Tables(0).Rows(0).Item("FechaFin"))

        End If

    End Sub

    Private Sub HabilitarEdicion()

        txt_FechaFin.Enabled = True
        txt_fechaInicio.Enabled = True
        txt_institucion.Enabled = True
        txt_titulo.Enabled = True
        cbo_areaEstudio.Enabled = True
        cbo_estadoEstudio.Enabled = True
        cbo_nivelEstudio.Enabled = True
        cmb_cargar.Enabled = True

    End Sub

    Private Sub DeshabilitarEdicion()

        txt_FechaFin.Enabled = False
        txt_fechaInicio.Enabled = False
        txt_institucion.Enabled = False
        txt_titulo.Enabled = False
        cbo_areaEstudio.Enabled = False
        cbo_estadoEstudio.Enabled = False
        cbo_nivelEstudio.Enabled = False
        cmb_cargar.Enabled = False

    End Sub

    Private Sub Inicio()

        DeshabilitarEdicion()
        CargarAreasEstudios()
        CargarEstadosEstudios()
        CargarNivelesEstudios()
        CargarDatos()

    End Sub

    Protected Sub cmb_editar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_editar.Click

        HabilitarEdicion()

    End Sub

End Class