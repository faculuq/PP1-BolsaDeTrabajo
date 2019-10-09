<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_provincias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_provincias))
        Me.cmb_cancelar = New System.Windows.Forms.Button()
        Me.cmb_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        Me.cbo_pais = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_modificar = New System.Windows.Forms.Button()
        Me.cmb_agregar = New System.Windows.Forms.Button()
        Me.cmb_limpiar = New System.Windows.Forms.Button()
        Me.grl_grilla = New System.Windows.Forms.DataGridView()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_cancelar
        '
        Me.cmb_cancelar.Location = New System.Drawing.Point(742, 376)
        Me.cmb_cancelar.Name = "cmb_cancelar"
        Me.cmb_cancelar.Size = New System.Drawing.Size(84, 34)
        Me.cmb_cancelar.TabIndex = 5
        Me.cmb_cancelar.Text = "Cancelar"
        Me.cmb_cancelar.UseVisualStyleBackColor = True
        '
        'cmb_aceptar
        '
        Me.cmb_aceptar.Location = New System.Drawing.Point(615, 376)
        Me.cmb_aceptar.Name = "cmb_aceptar"
        Me.cmb_aceptar.Size = New System.Drawing.Size(84, 34)
        Me.cmb_aceptar.TabIndex = 4
        Me.cmb_aceptar.Text = "Aceptar"
        Me.cmb_aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_estado)
        Me.GroupBox1.Controls.Add(Me.cbo_pais)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(814, 179)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion"
        '
        'cbo_estado
        '
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Location = New System.Drawing.Point(342, 133)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(177, 21)
        Me.cbo_estado.TabIndex = 3
        '
        'cbo_pais
        '
        Me.cbo_pais.FormattingEnabled = True
        Me.cbo_pais.Location = New System.Drawing.Point(342, 96)
        Me.cbo_pais.Name = "cbo_pais"
        Me.cbo_pais.Size = New System.Drawing.Size(177, 21)
        Me.cbo_pais.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(342, 59)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(177, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(342, 22)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(177, 20)
        Me.txt_id.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'cmb_modificar
        '
        Me.cmb_modificar.Location = New System.Drawing.Point(742, 139)
        Me.cmb_modificar.Name = "cmb_modificar"
        Me.cmb_modificar.Size = New System.Drawing.Size(84, 34)
        Me.cmb_modificar.TabIndex = 3
        Me.cmb_modificar.Text = "Modificar"
        Me.cmb_modificar.UseVisualStyleBackColor = True
        '
        'cmb_agregar
        '
        Me.cmb_agregar.Location = New System.Drawing.Point(615, 139)
        Me.cmb_agregar.Name = "cmb_agregar"
        Me.cmb_agregar.Size = New System.Drawing.Size(84, 34)
        Me.cmb_agregar.TabIndex = 2
        Me.cmb_agregar.Text = "Agregar"
        Me.cmb_agregar.UseVisualStyleBackColor = True
        '
        'cmb_limpiar
        '
        Me.cmb_limpiar.Location = New System.Drawing.Point(12, 139)
        Me.cmb_limpiar.Name = "cmb_limpiar"
        Me.cmb_limpiar.Size = New System.Drawing.Size(84, 34)
        Me.cmb_limpiar.TabIndex = 1
        Me.cmb_limpiar.Text = "Limpiar"
        Me.cmb_limpiar.UseVisualStyleBackColor = True
        '
        'grl_grilla
        '
        Me.grl_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_grilla.Location = New System.Drawing.Point(12, 12)
        Me.grl_grilla.Name = "grl_grilla"
        Me.grl_grilla.Size = New System.Drawing.Size(814, 121)
        Me.grl_grilla.TabIndex = 0
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.lbl_mensaje)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel.Location = New System.Drawing.Point(0, 437)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(838, 24)
        Me.Panel.TabIndex = 13
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(4, 4)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensaje.TabIndex = 0
        '
        'frm_provincias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 461)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.cmb_cancelar)
        Me.Controls.Add(Me.cmb_aceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_modificar)
        Me.Controls.Add(Me.cmb_agregar)
        Me.Controls.Add(Me.cmb_limpiar)
        Me.Controls.Add(Me.grl_grilla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_provincias"
        Me.Text = "Provincias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_estado As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_pais As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_modificar As System.Windows.Forms.Button
    Friend WithEvents cmb_agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_limpiar As System.Windows.Forms.Button
    Friend WithEvents grl_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label
End Class
