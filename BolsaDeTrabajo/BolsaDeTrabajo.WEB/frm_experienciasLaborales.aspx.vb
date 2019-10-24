Imports BolsaDeTrabajo.AD

Public Class frm_experienciasLaborales
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmb_cargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_cargar.Click

        Dim oExperiencia As New cExperienciasLaborales

        If txt_fechaFin.Text <> Nothing And txt_fechaInicio.Text <> Nothing And txt_nombreEmpresa.Text <> Nothing And txt_descripcion.Text <> Nothing Then
            oExperiencia.AgregarDatos(Session("IdPostulante"), cbo_puestoLaboral.SelectedValue, cbo_rubroEmp.SelectedValue, txt_nombreEmpresa.Text, txt_descripcion.Text, txt_fechaInicio.Text, txt_fechaFin.Text)
            MsgBox("Datos cargados correctamente.", vbInformation, "Experiencias laborales")
        End If

    End Sub



End Class