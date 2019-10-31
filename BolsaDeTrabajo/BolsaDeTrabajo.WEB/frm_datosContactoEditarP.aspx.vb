Imports BolsaDeTrabajo.AD

Public Class frm_datosContactoEditarP

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            Inicio()

        End If

    End Sub

    Protected Sub cmb_cargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_cargar.Click

        Dim oPostulante As New cPostulantes

        If txt_calle.Text <> Nothing And txt_numero.Text <> Nothing And txt_telCel.Text <> Nothing And txt_telFijo.Text <> Nothing And cbo_localidad.SelectedValue <> Nothing Then
            oPostulante.AgregarDatosContacto(Session("IdUsuario"), txt_telCel.Text, txt_telFijo.Text, cbo_localidad.SelectedValue, txt_calle.Text, txt_numero.Text)
            Response.Redirect("frm_datosEstudio.aspx", Session("IdUsuario"))
            MsgBox("Datos cargados con exito", vbInformation, "Datos Contacto")
        Else
            MsgBox("Complete todos los campos para continuar", vbInformation, "Datos Contacto")
        End If

    End Sub

    Private Sub CargarPaises()

        Dim ods As New DataSet
        Dim OPais As New cPaises

        ods = OPais.BuscarTodos
        cbo_pais.DataSource = ods.Tables(0)
        cbo_pais.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_pais.DataValueField = ods.Tables(0).Columns("IdPais").ToString
        cbo_pais.DataBind()

    End Sub

    Private Sub CargarProvincias()

        Dim ods As New DataSet
        Dim OProvincia As New cProvincias

        ods = OProvincia.BuscarXPais(cbo_pais.SelectedValue)
        cbo_provincia.DataSource = ods.Tables(0)
        cbo_provincia.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_provincia.DataValueField = ods.Tables(0).Columns("IdProvincia").ToString
        cbo_provincia.DataBind()

    End Sub

    Private Sub CargarDepartamentos()

        Dim ods As New DataSet
        Dim oDepartamento As New cDepartamentos

        ods = oDepartamento.BuscarXProvincia(cbo_provincia.SelectedValue)
        cbo_depto.DataSource = ods.Tables(0)
        cbo_depto.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_depto.DataValueField = ods.Tables(0).Columns("IdDepartamento").ToString
        cbo_depto.DataBind()

    End Sub

    Private Sub CargarLocalidades()

        Dim ods As New DataSet
        Dim oLocalidad As New cLocalidades

        ods = oLocalidad.BuscarXDepto(cbo_depto.SelectedValue)
        cbo_localidad.DataSource = ods.Tables(0)
        cbo_localidad.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_localidad.DataValueField = ods.Tables(0).Columns("IdLocalidad").ToString
        cbo_localidad.DataBind()

    End Sub

    Protected Sub cbo_pais_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_pais.SelectedIndexChanged

        CargarProvincias()

    End Sub

    Protected Sub cbo_provincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_provincia.SelectedIndexChanged

        CargarDepartamentos()

    End Sub

    Protected Sub cbo_depto_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_depto.SelectedIndexChanged

        CargarLocalidades()

    End Sub

    Private Sub CargarDatos()

        Dim ods As New DataSet
        Dim oPostulante As New cPostulantes

        ods = oPostulante.BuscarPorUsuario(Session("IdUsuario"))

        If ods.Tables(0).Rows.Count > 0 Then

            txt_telCel.Text = (ods.Tables(0).Rows(0).Item("TelefonoCelular"))
            txt_telFijo.Text = (ods.Tables(0).Rows(0).Item("TelefonoFijo"))
            cbo_localidad.Text = (ods.Tables(0).Rows(0).Item("IdLocalidad"))
            txt_calle.Text = (ods.Tables(0).Rows(0).Item("Calle"))
            txt_numero.Text = (ods.Tables(0).Rows(0).Item("Numero"))

        End If

    End Sub

    Private Sub HabilitarEdicion()

        txt_calle.Enabled = True
        txt_numero.Enabled = True
        txt_telCel.Enabled = True
        txt_telFijo.Enabled = True
        cbo_depto.Enabled = True
        cbo_localidad.Enabled = True
        cbo_pais.Enabled = True
        cbo_provincia.Enabled = True
        cmb_cargar.Enabled = True

    End Sub

    Private Sub DeshabilitarEdicion()

        txt_calle.Enabled = False
        txt_numero.Enabled = False
        txt_telCel.Enabled = False
        txt_telFijo.Enabled = False
        cbo_depto.Enabled = False
        cbo_localidad.Enabled = False
        cbo_pais.Enabled = False
        cbo_provincia.Enabled = False
        cmb_cargar.Enabled = False

    End Sub

    Private Sub Inicio()

        CargarPaises()
        CargarProvincias()
        CargarDepartamentos()
        CargarLocalidades()
        CargarDatos()
        DeshabilitarEdicion()

    End Sub

    Protected Sub cmb_editar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_editar.Click

        HabilitarEdicion()

    End Sub

End Class