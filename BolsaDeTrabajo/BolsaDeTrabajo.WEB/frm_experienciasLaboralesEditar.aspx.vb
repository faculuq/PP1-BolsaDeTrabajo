Imports BolsaDeTrabajo.AD

Public Class frm_experienciasLaboralesEditar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            Inicio()
            CargarDatos()

        End If

    End Sub

    Protected Sub cmb_cargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_cargar.Click

        Dim oExperiencia As New cExperienciasLaborales

        If txt_fechaFin.Text <> Nothing And txt_fechaInicio.Text <> Nothing And txt_nombreEmpresa.Text <> Nothing And txt_descripcion.Text <> Nothing Then
            oExperiencia.AgregarDatos(Session("IdPostulante"), cbo_puestoLaboral.SelectedValue, cbo_rubroEmp.SelectedValue, txt_nombreEmpresa.Text, txt_descripcion.Text, txt_fechaInicio.Text, txt_fechaFin.Text)
            DeshabilitarEdicion()
        End If

    End Sub

    Private Sub CargarAreas()

        Dim ods As New DataSet
        Dim oArea As New cAreasLaborales

        ods = oArea.BuscarTodos
        cbo_areaLaboral.DataSource = ods.Tables(0)
        cbo_areaLaboral.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_areaLaboral.DataValueField = ods.Tables(0).Columns("IdAreaLaboral").ToString
        cbo_areaLaboral.DataBind()

    End Sub

    Private Sub CargarPuestos()

        Dim ods As New DataSet
        Dim oPuesto As New cPuestosLaborales

        ods = oPuesto.BuscarXArea(cbo_areaLaboral.SelectedValue)
        cbo_puestoLaboral.DataSource = ods.Tables(0)
        cbo_puestoLaboral.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_puestoLaboral.DataValueField = ods.Tables(0).Columns("IdPuestoLaboral").ToString
        cbo_puestoLaboral.DataBind()

    End Sub

    Protected Sub cbo_areaLaboral_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_areaLaboral.SelectedIndexChanged

        CargarPuestos()

    End Sub

    Private Sub CargarRubros()

        Dim ods As New DataSet
        Dim oRubro As New cRubrosLaborales

        ods = oRubro.BuscarTodos
        cbo_rubroEmp.DataSource = ods.Tables(0)
        cbo_rubroEmp.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_rubroEmp.DataValueField = ods.Tables(0).Columns("IdRubroLaboral").ToString
        cbo_rubroEmp.DataBind()

    End Sub

    Private Sub CargarDatos()

        Dim ods As New DataSet
        Dim oExperiencia As New cExperienciasLaborales

        ods = oExperiencia.BuscarPorPostulante(Session("IdPostulante"))

        If ods.Tables(0).Rows.Count > 0 Then

            cbo_puestoLaboral.SelectedValue = (ods.Tables(0).Rows(0).Item("IdPuestoLaboral"))
            txt_fechaInicio.Text = (ods.Tables(0).Rows(0).Item("PeriodoDesde"))
            txt_fechaFin.Text = (ods.Tables(0).Rows(0).Item("PeriodoHasta"))
            cbo_rubroEmp.Text = (ods.Tables(0).Rows(0).Item("IdRubroLaboral"))
            txt_descripcion.Text = (ods.Tables(0).Rows(0).Item("DescripcionResponsabilidades"))
            txt_nombreEmpresa.Text = (ods.Tables(0).Rows(0).Item("NombreEmpresa"))

        End If

    End Sub

    Private Sub HabilitarEdicion()

        txt_descripcion.Enabled = True
        txt_fechaFin.Enabled = True
        txt_fechaInicio.Enabled = True
        txt_nombreEmpresa.Enabled = True
        cbo_areaLaboral.Enabled = True
        cbo_puestoLaboral.Enabled = True
        cbo_rubroEmp.Enabled = True
        cmb_cargar.Enabled = True

    End Sub

    Private Sub DeshabilitarEdicion()

        txt_descripcion.Enabled = False
        txt_fechaFin.Enabled = False
        txt_fechaInicio.Enabled = False
        txt_nombreEmpresa.Enabled = False
        cbo_areaLaboral.Enabled = False
        cbo_puestoLaboral.Enabled = False
        cbo_rubroEmp.Enabled = False
        cmb_cargar.Enabled = False

    End Sub

    Private Sub Inicio()

        DeshabilitarEdicion()
        CargarAreas()
        CargarPuestos()
        CargarRubros()

    End Sub

    Protected Sub cmb_editar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_editar.Click

        HabilitarEdicion()

    End Sub

End Class