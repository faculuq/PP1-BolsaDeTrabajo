Imports BolsaDeTrabajo.AD
Public Class frm_DatosContactoEmpresaEditar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmdEditarInformacion_Click(sender As Object, e As EventArgs) Handles cmdEditarInformacion.Click

    End Sub
    Private Sub CargarDatos()

        Dim ods As New DataSet
        Dim oEmpresa As New cEmpresas

        ods = oEmpresa.EmpresaBuscarPorUsuario(Session("IdUsuario"))

        If ods.Tables(0).Rows.Count > 0 Then

            txt_telFijo.Text = (ods.Tables(0).Rows(0).Item("TelefonoFijo"))
            cbo_pais.Text = (ods.Tables(0).Rows(0).Item("IdPais"))
            cbo_provincia.Text = (ods.Tables(0).Rows(0).Item("IdProvincia"))
            cbo_localidad.Text = (ods.Tables(0).Rows(0).Item("IdLocalidad"))
            cbo_depto.Text = (ods.Tables(0).Rows(0).Item("IdDepartamento"))
            txt_calle.Text = (ods.Tables(0).Rows(0).Item("Calle"))
            txt_numero.Text = (ods.Tables(0).Rows(0).Item("Numero"))

        End If

    End Sub

    Private Sub HabilitarEdicion()

        txt_calle.Enabled = True
        txt_numero.Enabled = True
        txt_telFijo.Enabled = True
        cbo_depto.Enabled = True
        cbo_localidad.Enabled = True
        cbo_pais.Enabled = True
        cbo_provincia.Enabled = True
        cmb_cargarE.Enabled = True

    End Sub

    Private Sub DeshabilitarEdicion()

        txt_calle.Enabled = False
        txt_numero.Enabled = False
        txt_telFijo.Enabled = False
        cbo_depto.Enabled = False
        cbo_localidad.Enabled = False
        cbo_pais.Enabled = False
        cbo_provincia.Enabled = False
        cmb_cargarE.Enabled = False

    End Sub

    Private Sub Inicio()

        CargarPaises()
        CargarProvincias()
        CargarDepartamentos()
        CargarLocalidades()
        CargarDatos()
        DeshabilitarEdicion()

    End Sub
End Class