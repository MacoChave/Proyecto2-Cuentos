<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desarrollador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCerrarTodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnALexico = New System.Windows.Forms.Button()
        Me.btnGenerarArchivos = New System.Windows.Forms.Button()
        Me.btnASintactico = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNuevo, Me.MenuAbrir, Me.MenuGuardar, Me.MenuCerrar, Me.MenuCerrarTodo, Me.MenuSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MenuNuevo
        '
        Me.MenuNuevo.Name = "MenuNuevo"
        Me.MenuNuevo.Size = New System.Drawing.Size(137, 22)
        Me.MenuNuevo.Text = "Nuevo"
        '
        'MenuAbrir
        '
        Me.MenuAbrir.Name = "MenuAbrir"
        Me.MenuAbrir.Size = New System.Drawing.Size(137, 22)
        Me.MenuAbrir.Text = "Abrir"
        '
        'MenuGuardar
        '
        Me.MenuGuardar.Name = "MenuGuardar"
        Me.MenuGuardar.Size = New System.Drawing.Size(137, 22)
        Me.MenuGuardar.Text = "Guardar"
        '
        'MenuCerrar
        '
        Me.MenuCerrar.Name = "MenuCerrar"
        Me.MenuCerrar.Size = New System.Drawing.Size(137, 22)
        Me.MenuCerrar.Text = "Cerrar"
        '
        'MenuCerrarTodo
        '
        Me.MenuCerrarTodo.Name = "MenuCerrarTodo"
        Me.MenuCerrarTodo.Size = New System.Drawing.Size(137, 22)
        Me.MenuCerrarTodo.Text = "Cerrar Todo"
        '
        'MenuSalir
        '
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(137, 22)
        Me.MenuSalir.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuManual, Me.MenuAcercaDe})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'MenuManual
        '
        Me.MenuManual.Name = "MenuManual"
        Me.MenuManual.Size = New System.Drawing.Size(173, 22)
        Me.MenuManual.Text = "Manual de Usuario"
        '
        'MenuAcercaDe
        '
        Me.MenuAcercaDe.Name = "MenuAcercaDe"
        Me.MenuAcercaDe.Size = New System.Drawing.Size(173, 22)
        Me.MenuAcercaDe.Text = "Acerda De"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnALexico)
        Me.GroupBox1.Controls.Add(Me.btnGenerarArchivos)
        Me.GroupBox1.Controls.Add(Me.btnASintactico)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(526, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 180)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Funciones"
        '
        'btnALexico
        '
        Me.btnALexico.Location = New System.Drawing.Point(35, 70)
        Me.btnALexico.Name = "btnALexico"
        Me.btnALexico.Size = New System.Drawing.Size(156, 23)
        Me.btnALexico.TabIndex = 0
        Me.btnALexico.Text = "Análisis Léxico"
        Me.btnALexico.UseVisualStyleBackColor = True
        '
        'btnGenerarArchivos
        '
        Me.btnGenerarArchivos.Location = New System.Drawing.Point(35, 128)
        Me.btnGenerarArchivos.Name = "btnGenerarArchivos"
        Me.btnGenerarArchivos.Size = New System.Drawing.Size(156, 23)
        Me.btnGenerarArchivos.TabIndex = 0
        Me.btnGenerarArchivos.Text = "Generar Archivos"
        Me.btnGenerarArchivos.UseVisualStyleBackColor = True
        '
        'btnASintactico
        '
        Me.btnASintactico.Location = New System.Drawing.Point(35, 99)
        Me.btnASintactico.Name = "btnASintactico"
        Me.btnASintactico.Size = New System.Drawing.Size(156, 23)
        Me.btnASintactico.TabIndex = 0
        Me.btnASintactico.Text = "Análisis Sintáctico"
        Me.btnASintactico.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Abrir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl.Location = New System.Drawing.Point(0, 24)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(500, 437)
        Me.TabControl.TabIndex = 2
        '
        'Desarrollador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Desarrollador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desarrollador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCerrarTodo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuManual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnALexico As System.Windows.Forms.Button
    Friend WithEvents btnGenerarArchivos As System.Windows.Forms.Button
    Friend WithEvents btnASintactico As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
End Class
