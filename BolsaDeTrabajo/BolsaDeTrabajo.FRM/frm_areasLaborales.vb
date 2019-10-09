Imports BolsaDeTrabajo.AD

Public Class frm_areasLaborales

#Region "VARIABLE"
    Private eEstado As EstadodelFormulario
#End Region

#Region "FORMULARIO"
    Private Sub frm_areasLaborales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub
#End Region

#Region "ENUMERACION"
    Public Enum EstadodelFormulario
        eConsulta = 1
        eAgregar = 2
        eEditar = 3
    End Enum
#End Region

#Region "PROPIEDADES"
    Public Property Estado() As EstadodelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As EstadodelFormulario)
            Select Case vNewValue
                Case EstadodelFormulario.eConsulta

                    Limpiar()
                    DesHabilitarEdicion()
                    DesHabilitarComandos()
                    cmb_agregar.Enabled = True
                    cmb_aceptar.Enabled = False
                    cmb_cancelar.Enabled = False
                    grl_grilla.Enabled = True
                    Panel.BackColor = Color.Aqua
                    lbl_mensaje.Text = "Consultando"
                    lbl_mensaje.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabilitarEdicion()
                    txt_id.Enabled = False
                    cmb_aceptar.Enabled = True
                    cmb_cancelar.Enabled = True
                    DesHabilitarComandos()
                    grl_grilla.Enabled = False
                    Limpiar()
                    txt_nombre.Focus()
                    Panel.BackColor = Color.LightBlue
                    lbl_mensaje.Text = "Agregando"
                    lbl_mensaje.ForeColor = Color.Black

                Case EstadodelFormulario.eEditar

                    HabilitarEdicion()
                    txt_id.Enabled = False
                    cmb_aceptar.Enabled = True
                    cmb_cancelar.Enabled = True
                    DesHabilitarComandos()
                    grl_grilla.Enabled = False
                    Panel.BackColor = Color.LavenderBlush
                    lbl_mensaje.Text = "Modificando"
                    lbl_mensaje.ForeColor = Color.Black

            End Select
            eEstado = vNewValue
        End Set
    End Property
#End Region

#Region "PROCEDIMIENTOS"

    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub

    Private Sub BuscarPorID(ByVal IdAreaLaboral As Integer)


        Dim oDs As New DataSet
        Dim oArea As New cAreasLaborales

        oDs = oArea.BuscarPorID(IdAreaLaboral)
        txt_id.Text = oDs.Tables(0).Rows(0).Item("IdAreaLaboral")
        txt_nombre.Text = oDs.Tables(0).Rows(0).Item("Nombre")

        oDs = Nothing
        oArea = Nothing

    End Sub

    Private Sub BuscarTodos()

        Dim oDs As New DataSet
        Dim oArea As New cAreasLaborales

        oDs = oArea.BuscarTodos
        grl_grilla.DataSource = oDs.Tables(0)
        grl_grilla.Columns(0).HeaderText = "Cod."
        grl_grilla.Columns(0).Width = 50
        oDs = Nothing
        oArea = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txt_id.Text = " "
        txt_nombre.Text = " "
        chk_activo.Checked = True

    End Sub

    Private Sub HabilitarEdicion()

        txt_id.Enabled = True
        txt_nombre.Enabled = True
        chk_activo.Enabled = True

    End Sub

    Private Sub DesHabilitarEdicion()

        txt_id.Enabled = False
        txt_nombre.Enabled = False
        chk_activo.Enabled = False

    End Sub

    Private Sub HabilitarComandos()

        cmb_agregar.Enabled = True
        cmb_modificar.Enabled = True
    End Sub

    Private Sub DesHabilitarComandos()

        cmb_agregar.Enabled = False
        cmb_modificar.Enabled = False


    End Sub
#End Region

#Region "FUNCIONES"


    Private Function Validar() As Boolean
        If txt_nombre.Text = "" Then
            MsgBox("Debe completar el nombre del Area", MsgBoxStyle.Exclamation, "Mensaje")
            Return False
        End If
        Return True
    End Function
#End Region

#Region "GRILLA"

    Private Sub grl_grilla_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grl_grilla.DoubleClick
        BuscarPorID(grl_grilla.CurrentRow.Cells(0).Value)
        cmb_modificar.Enabled = True
    End Sub
#End Region

#Region "BOTONES DE COMANDOS"



    Private Sub cmb_agregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_agregar.Click
        Me.Estado = EstadodelFormulario.eAgregar

        txt_nombre.Enabled = True
    End Sub

    Private Sub cmb_aceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_aceptar.Click
        Try
            If Validar() = True Then
                Dim oArea As New cAreasLaborales

                If Me.Estado = EstadodelFormulario.eEditar Then
                    oArea.Modificar(txt_id.Text, txt_nombre.Text, chk_activo.Checked)
                    MsgBox("Se modificó correctamente el Area : " + txt_id.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oArea.Agregar(txt_nombre.Text, chk_activo.Checked)
                    MsgBox("Se agregó correctamente el Area " + txt_nombre.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If
                Me.Estado = EstadodelFormulario.eConsulta
            End If
        Catch
            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmb_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cancelar.Click
        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
                 "Se perderán las ultimas modificaciones", _
                 vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta
        End If
        Exit Sub
    End Sub

    Private Sub cmb_modificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_modificar.Click
        Me.Estado = EstadodelFormulario.eEditar
    End Sub

    Private Sub cmb_limpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub
#End Region

End Class