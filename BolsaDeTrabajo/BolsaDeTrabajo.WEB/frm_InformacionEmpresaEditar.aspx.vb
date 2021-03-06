﻿Imports BolsaDeTrabajo.AD

Public Class frm_InformacionEmpresaEditar

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            Inicio()

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

    Private Sub CargarRubro()

        Dim ods As New DataSet
        Dim oRubro As New cRubrosLaborales

        ods = oRubro.BuscarTodos()

        cbo_IdRubro.DataSource = ods.Tables(0)
        cbo_IdRubro.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_IdRubro.DataValueField = ods.Tables(0).Columns("IdRubroLaboral").ToString
        cbo_IdRubro.DataBind()

    End Sub

    Protected Sub cmdEditarInformacion_Click(sender As Object, e As EventArgs) Handles cmdEditarInformacion.Click
        HabilitarEdicion()

    End Sub

    Private Sub CargarDatos()

        Dim ods As New DataSet
        Dim oEmpresa As New cEmpresas

        ods = oEmpresa.BuscarPorUsuario(Session("IdUsuario"))

        If ods.Tables(0).Rows.Count > 0 Then

            txt_nombre.Text = (ods.Tables(0).Rows(0).Item("Nombre"))
            txt_RazonSocial.Text = (ods.Tables(0).Rows(0).Item("RazonSocial"))
            cbo_tipoDoc.SelectedValue = (ods.Tables(0).Rows(0).Item("IdTipoDocumento"))
            txt_numeroDoc.Text = (ods.Tables(0).Rows(0).Item("NumeroDocumento"))
            txt_Fundacion.Text = (ods.Tables(0).Rows(0).Item("FechaFundacion"))
            cbo_IdRubro.SelectedValue = (ods.Tables(0).Rows(0).Item("IdRubro"))

        End If

    End Sub

    Private Sub HabilitarEdicion()

        txt_nombre.Enabled = True
        txt_RazonSocial.Enabled = True
        txt_numeroDoc.Enabled = True
        cbo_IdRubro.Enabled = True
        cbo_tipoDoc.Enabled = True
        txt_Fundacion.Enabled = True
        cmd_GuardarDatos.Enabled = True

    End Sub

    Private Sub DeshabilitarEdicion()

        txt_nombre.Enabled = False
        txt_RazonSocial.Enabled = False
        cbo_tipoDoc.Enabled = False
        txt_numeroDoc.Enabled = False
        txt_Fundacion.Enabled = False
        cbo_IdRubro.Enabled = False
        cmd_GuardarDatos.Enabled = False

    End Sub

    Private Sub Inicio()

        CargarDocumentos()
        CargarDatos()
        CargarRubro()
        DeshabilitarEdicion()

    End Sub

    Protected Sub cmd_GuardarDatos_Click(sender As Object, e As EventArgs) Handles cmd_GuardarDatos.Click

        Dim oEmpresas As New cEmpresas

        If txt_nombre.Text <> Nothing And txt_RazonSocial.Text <> Nothing And cbo_tipoDoc.SelectedValue <> Nothing And txt_numeroDoc.Text <> Nothing And txt_Fundacion.Text <> Nothing And cbo_IdRubro.SelectedValue <> Nothing Then

            oEmpresas.GuardarInformacion(Session("IdUsuario"), txt_nombre.Text, txt_RazonSocial.Text, cbo_tipoDoc.SelectedValue, txt_numeroDoc.Text, txt_Fundacion.Text, cbo_IdRubro.SelectedValue)
            Response.Redirect("frm_datosContactoEmpresa.aspx")
            'MsgBox("Datos agregados correctamente", vbInformation, "Datos Personales")

        Else

            MsgBox("Complete todos los campos para continuar", vbInformation, "Datos Personales")

        End If

    End Sub
End Class