﻿Imports BolsaDeTrabajo.AD

Public Class frm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            CargarDocumentos()
            CargarRubro()
            cbo_tipoDoc.SelectedValue = 2
            cbo_tipoDoc.Enabled = False


        End If

    End Sub

    Protected Sub cmd_GuardarDatos_Click(sender As Object, e As EventArgs) Handles cmd_GuardarDatos.Click

        Dim oEmpresas As New cEmpresas

        If txt_nombre.Text <> Nothing And txt_RazonSocial.Text <> Nothing And cbo_tipoDoc.SelectedValue <> Nothing And txt_numeroDoc.Text <> Nothing And txt_Fundacion.Text <> Nothing And cbo_IdRubro.SelectedValue <> Nothing Then

            oEmpresas.GuardarInformacion(Session("IdUsuario"), txt_nombre.Text, txt_RazonSocial.Text, cbo_tipoDoc.SelectedValue, txt_numeroDoc.Text, cbo_IdRubro.SelectedValue, txt_Fundacion.Text)
            Response.Redirect("frm_datosContactoEmpresa.aspx")
            ' MsgBox("Datos agregados correctamente", vbInformation, "Datos Personales")

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

    Private Sub CargarRubro()

        Dim ods As New DataSet
        Dim oRubro As New cRubrosLaborales

        ods = oRubro.BuscarTodos()

        cbo_IdRubro.DataSource = ods.Tables(0)
        cbo_IdRubro.DataTextField = ods.Tables(0).Columns("Nombre").ToString
        cbo_IdRubro.DataValueField = ods.Tables(0).Columns("IdRubroLaboral").ToString
        cbo_IdRubro.DataBind()

    End Sub

End Class