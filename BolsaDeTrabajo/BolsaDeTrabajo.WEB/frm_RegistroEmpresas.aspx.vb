Imports BolsaDeTrabajo.AD

Public Class frm_RegistroEmpresas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmb_registrarse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_registrarse.Click

        Dim oUsuario As New cUsuarios
        Dim oEmpresa As New cEmpresas

        If txt_email.Text <> Nothing And txt_pass1.Text <> Nothing And txt_pass2.Text <> Nothing Then
            If txt_pass1.Text = txt_pass2.Text Then
                Dim resultado As Integer
                resultado = oUsuario.Agregar(txt_email.Text, txt_pass1.Text, 1)
                Session("IdUsuario") = resultado
                oEmpresa.Agregar(resultado)
                Response.Redirect("frm_InformacionEmpresa.aspx") 'cambiar a frm de datos empresa
                MsgBox("Registro Correcto", vbInformation, "Resgistrarse")

            Else
                MsgBox("Las contrasenas no coinciden", vbInformation, "Resgistrarse")
            End If
        Else
            MsgBox("Complete todos los campos para registrarse", vbInformation, "Resgistrarse")
        End If


    End Sub
End Class