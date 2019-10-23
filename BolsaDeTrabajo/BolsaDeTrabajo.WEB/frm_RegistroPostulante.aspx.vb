Imports BolsaDeTrabajo.AD

Public Class frm_RegistroPostulante

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmb_registrarse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_registrarse.Click

        Dim oUsuario As New cUsuarios
        Dim oPostulante As New cPostulantes
        Dim oEstudio As New cEstudios
        Dim oExperiencia As New cExperienciasLaborales

        If txt_email.Text <> Nothing And txt_pass1.Text <> Nothing And txt_pass2.Text <> Nothing Then

            If txt_pass1.Text = txt_pass2.Text Then

                Dim iduser As Integer
                Dim idpos As Integer
                iduser = oUsuario.Agregar(txt_email.Text, txt_pass1.Text)
                Session("IdUsuario") = iduser
                idpos = oPostulante.Agregar(iduser)
                Session("IdPostulante") = idpos
                oEstudio.Agregar(idpos)
                oExperiencia.Agregar(idpos)
                Response.Redirect("frm_datosPersonales.aspx")
                MsgBox("Registro Correcto", vbInformation, "Resgistrarse")

            Else

                MsgBox("Las contrasenas no coinciden", vbInformation, "Resgistrarse")

            End If

        Else

            MsgBox("Complete todos los campos para registrarse", vbInformation, "Resgistrarse")

        End If

    End Sub
End Class