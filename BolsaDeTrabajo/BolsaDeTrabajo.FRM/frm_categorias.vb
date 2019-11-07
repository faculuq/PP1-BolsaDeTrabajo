Imports BolsaDeTrabajo.AD

Public Class frm_categorias

#Region "Variables"

    Private eEstado As EstadodelFormulario

#End Region

#Region "Enumeraciones"

    Public Enum EstadodelFormulario
        eConsulta = 1
        eAgregar = 2
        eEditar = 3
    End Enum

#End Region

#Region "Propiedades"


    Public Property Estado() As EstadodelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As EstadodelFormulario)


            Select Case vNewValue

                Case EstadodelFormulario.eConsulta

                    Limpiar()
                    DesHabilitarEdicion()
                    HabilitarComandos()
                    cmb_agregar.Enabled = True
                    cmb_aceptar.Enabled = False
                    cmb_cancelar.Enabled = False
                    grl_grilla.Enabled = True
                    Panel.BackColor = Color.White
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
                    Panel.BackColor = Color.Red
                    lbl_mensaje.Text = "Agregando"
                    lbl_mensaje.ForeColor = Color.White


                Case EstadodelFormulario.eEditar

                    HabilitarEdicion()
                    txt_id.Enabled = False
                    cmb_aceptar.Enabled = True
                    cmb_cancelar.Enabled = True
                    DesHabilitarComandos()
                    grl_grilla.Enabled = False
                    Panel.BackColor = Color.Red
                    lbl_mensaje.Text = "Modificando"
                    lbl_mensaje.ForeColor = Color.White



            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "Formulario"

    Private Sub frm_categorias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.F3 And cmb_agregar.Enabled = True Then ' agregar
            Me.Estado = EstadodelFormulario.eAgregar
        End If

        If e.KeyCode = Keys.F4 And cmb_modificar.Enabled = True Then ' modificar
            Me.Estado = EstadodelFormulario.eEditar
        End If


        If e.KeyCode = Keys.F12 And cmb_limpiar.Enabled = True Then ' limpiar
            Me.Estado = EstadodelFormulario.eConsulta
        End If

    End Sub

    Private Sub frm_categorias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If

    End Sub


    Private Sub frm_categorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eConsulta

    End Sub



#End Region

#Region "Procedimientos"

    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub

    Private Sub BuscarTodos()


        Dim oDs As New DataSet
        Dim oCategorias As New cCategorias
        oDs = oCategorias.BuscarTodos

        grl_grilla.DataSource = oDs.Tables(0)

        grl_grilla.Columns(0).HeaderText = "Cod."
        grl_grilla.Columns(0).Width = 50
        grl_grilla.Columns(1).Width = 350
        grl_grilla.Columns(2).Width = 350

        oDs = Nothing
        oCategorias = Nothing

    End Sub

    Private Sub BuscarPorID(ByVal IdCategoria As Integer)


        Dim oDs As New DataSet
        Dim oCategorias As New cCategorias

        oDs = oCategorias.BuscarXId(IdCategoria)

        txt_id.Text = oDs.Tables(0).Rows(0).Item("IdCategoria")
        txt_nombre.Text = oDs.Tables(0).Rows(0).Item("Nombre")
        chk_activo.Checked = oDs.Tables(0).Rows(0).Item("Activo")

        oDs = Nothing
        oCategorias = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txt_id.Text = ""
        txt_nombre.Text = ""


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

#Region "Botones de comando"

    Private Sub cmb_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmb_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_modificar.Click
        Me.Estado = EstadodelFormulario.eEditar
    End Sub

    Private Sub cmb_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_agregar.Click
        Me.Estado = EstadodelFormulario.eAgregar
    End Sub

    Private Sub cmb_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_aceptar.Click

        Try

            If Validar() = True Then


                Dim oCategorias As New cCategorias


                If Me.Estado = EstadodelFormulario.eEditar Then
                    oCategorias.Modificar(txt_id.Text, txt_nombre.Text, chk_activo.Checked)
                    MsgBox("Se modificó correctamente la categoria código Nro: " + txt_id.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oCategorias.Agregar(txt_nombre.Text, chk_activo.Checked)
                    MsgBox("Se agregó correctamente la categoria " + txt_nombre.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub cmb_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cancelar.Click
        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
              "Se perderán las ultimas modificaciones", _
              vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta

        End If
    End Sub

#End Region

#Region "Grilla"

    Private Sub grl_gilla_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grl_grilla.DoubleClick
        BuscarPorID(grl_grilla.CurrentRow.Cells(0).Value)
        cmb_modificar.Enabled = True
    End Sub

#End Region

#Region "Funciones"

    Private Function Validar() As Boolean

        If txt_nombre.Text = "" Then

            MsgBox("Complete el nombre de la categoria", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region


End Class