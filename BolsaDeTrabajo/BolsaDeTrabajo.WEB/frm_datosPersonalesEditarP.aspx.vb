Imports BolsaDeTrabajo.AD

Public Class frm_editarDatosPersonalesP
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            Session("IdUsuario") = 17
            Inicio()

        End If

    End Sub

    Protected Sub cmb_cargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_cargar.Click

        Dim oPostulante As New cPostulantes

        If txt_apellido.Text <> Nothing And txt_nombre.Text <> Nothing And txt_numeroDoc.Text <> Nothing And cbo_estadoCivil.SelectedValue <> Nothing And cbo_sitLaboral.SelectedValue <> Nothing And cbo_tipoDoc.SelectedValue <> Nothing Then
            oPostulante.AgregarDatosPersonales(Session("IdUsuario"), txt_nombre.Text, txt_apellido.Text, cbo_tipoDoc.SelectedValue, txt_numeroDoc.Text, cbo_estadoCivil.SelectedValue, cbo_sitLaboral.SelectedValue, txt_fechaNac.Text)
            DeshabilitarEdicion()
        Else
            MsgBox("Complete todos los campos para continuar", vbInformation, "Datos Personales")
        End If
    End Sub

    Private Sub CargarDocumentos()

        Dim ods As New DataSet
        Dim oTipoDoc As New cTiposDocumentos

        ods = oTipoDoc.BuscarTodos()

        cbo_tipoDoc.DataSource = ods.Tables(0)
        cbo_tipoDoc.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_tipoDoc.DataValueField = ods.Tables(0).Columns("IdTipoDocumento").ToString
        cbo_tipoDoc.DataBind()

    End Sub

    Private Sub CargarEstadosCiviles()

        Dim ods As New DataSet
        Dim oEstadoCivil As New cEstadosCiviles

        ods = oEstadoCivil.BuscarTodos()

        cbo_estadoCivil.DataSource = ods.Tables(0)
        cbo_estadoCivil.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_estadoCivil.DataValueField = ods.Tables(0).Columns("IdEstadoCivil").ToString
        cbo_estadoCivil.DataBind()

    End Sub

    Private Sub CargarSituacionesLaborales()

        Dim ods As New DataSet
        Dim oSituacionLAboral As New cSituacionesLaborales

        ods = oSituacionLAboral.BuscarTodos()

        cbo_sitLaboral.DataSource = ods.Tables(0)
        cbo_sitLaboral.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_sitLaboral.DataValueField = ods.Tables(0).Columns("IdSituacionLaboral").ToString
        cbo_sitLaboral.DataBind()

    End Sub

    Private Sub CargarDatos()

        Dim ods As New DataSet
        Dim oPostulante As New cPostulantes

        ods = oPostulante.BuscarPorUsuario(Session("IdUsuario"))

        If ods.Tables(0).Rows.Count > 0 Then

            txt_nombre.Text = (ods.Tables(0).Rows(0).Item("Nombre"))
            txt_apellido.Text = (ods.Tables(0).Rows(0).Item("Apellido"))
            cbo_tipoDoc.Text = (ods.Tables(0).Rows(0).Item("IdTipoDocumento"))
            txt_numeroDoc.Text = (ods.Tables(0).Rows(0).Item("NumeroDocumento"))
            cbo_estadoCivil.SelectedValue = (ods.Tables(0).Rows(0).Item("IdEstadoCivil"))
            cbo_sitLaboral.SelectedValue = (ods.Tables(0).Rows(0).Item("IdSituacionLaboralTipo"))
            txt_fechaNac.Text = (ods.Tables(0).Rows(0).Item("FechaNacimiento"))

        End If

    End Sub

    Private Sub HabilitarEdicion()

        txt_apellido.Enabled = True
        txt_fechaNac.Enabled = True
        txt_nombre.Enabled = True
        txt_numeroDoc.Enabled = True
        cbo_estadoCivil.Enabled = True
        cbo_sitLaboral.Enabled = True
        cbo_tipoDoc.Enabled = True
        cmb_cargar.Enabled = True

    End Sub

    Private Sub DeshabilitarEdicion()

        txt_apellido.Enabled = False
        txt_fechaNac.Enabled = False
        txt_nombre.Enabled = False
        txt_numeroDoc.Enabled = False
        cbo_estadoCivil.Enabled = False
        cbo_sitLaboral.Enabled = False
        cbo_tipoDoc.Enabled = False
        cmb_cargar.Enabled = False

    End Sub

    Private Sub Inicio()

        CargarDocumentos()
        CargarEstadosCiviles()
        CargarSituacionesLaborales()
        CargarDatos()
        DeshabilitarEdicion()

    End Sub

    Protected Sub cmb_editar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_editar.Click

        HabilitarEdicion()

    End Sub
End Class