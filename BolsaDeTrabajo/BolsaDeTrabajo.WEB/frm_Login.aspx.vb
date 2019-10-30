Imports BolsaDeTrabajo.AD

Public Class frm_Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmb_inicio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_inicio.Click

        Dim oDs As New DataSet
        Dim oUsuario As New cUsuarios


        oDs = oUsuario.BuscarPorLoginPass(txt_usuario.Text, txt_password.Text)

        If oDs.Tables(0).Rows.Count > 0 Then

            Session("IdUsuario") = oDs.Tables(0).Rows(0).Item("IdUsuario")


        Else

            MsgBox("El usuario o contraseña, no coinciden con un usuario válido", MsgBoxStyle.Exclamation, "Iniciar Sesión")

        End If

        If oDs.Tables(0).Rows(0).Item("IdTipoUsuario") = 1 Then

            Response.Redirect("frm_inicioEmpresa.aspx")

        Else

            Response.Redirect("frm_inicioPostulante.aspx")

        End If


    End Sub
End Class