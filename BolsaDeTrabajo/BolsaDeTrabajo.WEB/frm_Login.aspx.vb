Imports BolsaDeTrabajo.AD

Public Class frm_Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmb_inicio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_inicio.Click

        Dim oDs As New DataSet
        Dim oUsuario As New cUsuarios
        Dim oPostulante As New cPostulantes
        Dim oEmpresa As New cEmpresas
        Dim odsp As New DataSet
        Dim odse As New DataSet


        oDs = oUsuario.BuscarPorLoginPass(txt_usuario.Text, txt_password.Text)

        If oDs.Tables(0).Rows.Count > 0 Then

            Session("IdUsuario") = oDs.Tables(0).Rows(0).Item("IdUsuario")
            
            'crear procedure que busque el id al iniciar el frm

        Else

            MsgBox("El usuario o contraseña, no coinciden con un usuario válido", MsgBoxStyle.Exclamation, "Iniciar Sesión")

        End If

        If oDs.Tables(0).Rows(0).Item("IdTipoUsuario") = 1 Then

            odse = oEmpresa.BuscarIdEmpresa(Session("IdUsuario"))
            Session("IdEmpresa") = odsp.Tables(0).Rows(0).Item("IdEmpresa")
            Response.Redirect("frm_inicioEmpresa.aspx")

        Else
            odsp = oPostulante.BuscarIdPostulante(Session("IdUsuario"))
            Session("IdPostulante") = odsp.Tables(0).Rows(0).Item("IdPostulante")
            Response.Redirect("frm_inicioPostulante.aspx")

        End If


    End Sub
End Class