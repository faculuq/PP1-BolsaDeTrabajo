Imports BolsaDeTrabajo.AD

Public Class frm_datosContactoEditarP
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            CargarPaises()
            CargarProvincias()
            CargarDepartamentos()
            CargarLocalidades()

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
        Dim OProvincia As New CProvincias

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

End Class