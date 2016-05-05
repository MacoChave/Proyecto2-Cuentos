<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Didactico
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
        Me.PanelCuadros = New System.Windows.Forms.Panel()
        Me.RchTxtTexto = New System.Windows.Forms.RichTextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PanelCuadros.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCuadros
        '
        Me.PanelCuadros.AutoScroll = True
        Me.PanelCuadros.Controls.Add(Me.ListView1)
        Me.PanelCuadros.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelCuadros.Location = New System.Drawing.Point(0, 0)
        Me.PanelCuadros.Name = "PanelCuadros"
        Me.PanelCuadros.Size = New System.Drawing.Size(333, 461)
        Me.PanelCuadros.TabIndex = 0
        '
        'RchTxtTexto
        '
        Me.RchTxtTexto.Dock = System.Windows.Forms.DockStyle.Right
        Me.RchTxtTexto.Location = New System.Drawing.Point(356, 0)
        Me.RchTxtTexto.Name = "RchTxtTexto"
        Me.RchTxtTexto.ReadOnly = True
        Me.RchTxtTexto.Size = New System.Drawing.Size(328, 461)
        Me.RchTxtTexto.TabIndex = 1
        Me.RchTxtTexto.Text = ""
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(3, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(327, 437)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Didactico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.RchTxtTexto)
        Me.Controls.Add(Me.PanelCuadros)
        Me.Name = "Didactico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Didactico"
        Me.PanelCuadros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelCuadros As System.Windows.Forms.Panel
    Friend WithEvents RchTxtTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
