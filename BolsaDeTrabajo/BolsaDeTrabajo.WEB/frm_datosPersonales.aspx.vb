Imports BolsaDeTrabajo.AD

Public Class frm_datosPersonales
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CargarDocumentos()
        CargarEstadosCiviles()
        CargarSituacionesLaborales()

    End Sub

    Protected Sub cmb_cargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_cargar.Click

        Dim oPostulante As New cPostulantes

        If txt_apellido.Text <> Nothing And txt_nombre.Text <> Nothing And txt_numeroDoc.Text <> Nothing And cbo_estadoCivil.SelectedValue <> Nothing And cbo_sitLaboral.SelectedValue <> Nothing And cbo_tipoDoc.SelectedValue <> Nothing Then
            oPostulante.AgregarDatosPersonales(Session("IdUsuario"), txt_nombre.Text, txt_apellido.Text, cbo_tipoDoc.SelectedValue, txt_numeroDoc.Text, cbo_estadoCivil.SelectedValue, cbo_sitLaboral.SelectedValue, txt_fechaNac.Text)
            Response.Redirect("frm_datosContacto.aspx", Session("IdUsuario"))
            MsgBox("Datos agregados correctamente", vbInformation, "Datos Personales")
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

End Class