<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UbicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorvinciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConocimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SituacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NivelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UbicacionToolStripMenuItem, Me.ConocimientosToolStripMenuItem, Me.EstadosToolStripMenuItem, Me.LaboralesToolStripMenuItem, Me.EstudiosToolStripMenuItem, Me.TiposDocumentosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(990, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UbicacionToolStripMenuItem
        '
        Me.UbicacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaisesToolStripMenuItem, Me.PorvinciasToolStripMenuItem, Me.DepartamentosToolStripMenuItem, Me.LocalidadesToolStripMenuItem})
        Me.UbicacionToolStripMenuItem.Name = "UbicacionToolStripMenuItem"
        Me.UbicacionToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.UbicacionToolStripMenuItem.Text = "&Ubicacion"
        Me.UbicacionToolStripMenuItem.ToolTipText = "Dar de alta: Paises, Provincias, Departamentos y Localidades"
        '
        'PaisesToolStripMenuItem
        '
        Me.PaisesToolStripMenuItem.Name = "PaisesToolStripMenuItem"
        Me.PaisesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PaisesToolStripMenuItem.Text = "&Paises"
        '
        'PorvinciasToolStripMenuItem
        '
        Me.PorvinciasToolStripMenuItem.Name = "PorvinciasToolStripMenuItem"
        Me.PorvinciasToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PorvinciasToolStripMenuItem.Text = "P&rovincias"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DepartamentosToolStripMenuItem.Text = "&Departamentos"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LocalidadesToolStripMenuItem.Text = "&Localidades"
        '
        'ConocimientosToolStripMenuItem
        '
        Me.ConocimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposToolStripMenuItem, Me.RubrosToolStripMenuItem})
        Me.ConocimientosToolStripMenuItem.Name = "ConocimientosToolStripMenuItem"
        Me.ConocimientosToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ConocimientosToolStripMenuItem.Text = "&Conocimientos"
        '
        'TiposToolStripMenuItem
        '
        Me.TiposToolStripMenuItem.Name = "TiposToolStripMenuItem"
        Me.TiposToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.TiposToolStripMenuItem.Text = "&Tipos"
        '
        'RubrosToolStripMenuItem
        '
        Me.RubrosToolStripMenuItem.Name = "RubrosToolStripMenuItem"
        Me.RubrosToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.RubrosToolStripMenuItem.Text = "&Rubros"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.EstadosToolStripMenuItem1})
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.EstadosToolStripMenuItem.Text = "&Estados"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CategoriasToolStripMenuItem.Text = "&Categorias"
        '
        'EstadosToolStripMenuItem1
        '
        Me.EstadosToolStripMenuItem1.Name = "EstadosToolStripMenuItem1"
        Me.EstadosToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.EstadosToolStripMenuItem1.Text = "&Estados"
        '
        'LaboralesToolStripMenuItem
        '
        Me.LaboralesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RubrosToolStripMenuItem1, Me.AreasToolStripMenuItem, Me.SituacionesToolStripMenuItem, Me.PuestosToolStripMenuItem})
        Me.LaboralesToolStripMenuItem.Name = "LaboralesToolStripMenuItem"
        Me.LaboralesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.LaboralesToolStripMenuItem.Text = "&Laborales"
        '
        'RubrosToolStripMenuItem1
        '
        Me.RubrosToolStripMenuItem1.Name = "RubrosToolStripMenuItem1"
        Me.RubrosToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.RubrosToolStripMenuItem1.Text = "&Rubros"
        '
        'AreasToolStripMenuItem
        '
        Me.AreasToolStripMenuItem.Name = "AreasToolStripMenuItem"
        Me.AreasToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AreasToolStripMenuItem.Text = "&Areas"
        '
        'SituacionesToolStripMenuItem
        '
        Me.SituacionesToolStripMenuItem.Name = "SituacionesToolStripMenuItem"
        Me.SituacionesToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SituacionesToolStripMenuItem.Text = "&Situaciones"
        '
        'PuestosToolStripMenuItem
        '
        Me.PuestosToolStripMenuItem.Name = "PuestosToolStripMenuItem"
        Me.PuestosToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.PuestosToolStripMenuItem.Text = "&Puestos"
        '
        'EstudiosToolStripMenuItem
        '
        Me.EstudiosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NivelesToolStripMenuItem, Me.EstadosToolStripMenuItem2, Me.AreasToolStripMenuItem1})
        Me.EstudiosToolStripMenuItem.Name = "EstudiosToolStripMenuItem"
        Me.EstudiosToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.EstudiosToolStripMenuItem.Text = "&Estudios"
        '
        'NivelesToolStripMenuItem
        '
        Me.NivelesToolStripMenuItem.Name = "NivelesToolStripMenuItem"
        Me.NivelesToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NivelesToolStripMenuItem.Text = "&Niveles"
        '
        'EstadosToolStripMenuItem2
        '
        Me.EstadosToolStripMenuItem2.Name = "EstadosToolStripMenuItem2"
        Me.EstadosToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.EstadosToolStripMenuItem2.Text = "&Estados"
        '
        'AreasToolStripMenuItem1
        '
        Me.AreasToolStripMenuItem1.Name = "AreasToolStripMenuItem1"
        Me.AreasToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.AreasToolStripMenuItem1.Text = "&Areas"
        '
        'TiposDocumentosToolStripMenuItem
        '
        Me.TiposDocumentosToolStripMenuItem.Name = "TiposDocumentosToolStripMenuItem"
        Me.TiposDocumentosToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.TiposDocumentosToolStripMenuItem.Text = "&Tipos Documentos"
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(990, 540)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_principal"
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UbicacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaisesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorvinciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ConocimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaboralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SituacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstudiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NivelesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
