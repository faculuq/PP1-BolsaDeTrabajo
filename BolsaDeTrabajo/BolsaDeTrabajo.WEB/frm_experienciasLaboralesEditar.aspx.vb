Imports BolsaDeTrabajo.AD

Public Class frm_experienciasLaboralesEditar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            CargarAreas()
            CargarPuestos()
            CargarRubros()

        End If

    End Sub

    Protected Sub cmb_cargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_cargar.Click

        Dim oExperiencia As New cExperienciasLaborales

        If txt_fechaFin.Text <> Nothing And txt_fechaInicio.Text <> Nothing And txt_nombreEmpresa.Text <> Nothing And txt_descripcion.Text <> Nothing Then
            oExperiencia.AgregarDatos(Session("IdPostulante"), cbo_puestoLaboral.SelectedValue, cbo_rubroEmp.SelectedValue, txt_nombreEmpresa.Text, txt_descripcion.Text, txt_fechaInicio.Text, txt_fechaFin.Text)
            MsgBox("Datos cargados correctamente.", vbInformation, "Experiencias laborales")
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

End Class