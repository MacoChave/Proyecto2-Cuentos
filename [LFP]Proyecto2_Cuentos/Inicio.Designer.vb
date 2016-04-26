<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.btnDesarrollador = New System.Windows.Forms.Button()
        Me.btnDidactico = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDesarrollador
        '
        Me.btnDesarrollador.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDesarrollador.Location = New System.Drawing.Point(0, 0)
        Me.btnDesarrollador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDesarrollador.Name = "btnDesarrollador"
        Me.btnDesarrollador.Size = New System.Drawing.Size(242, 261)
        Me.btnDesarrollador.TabIndex = 0
        Me.btnDesarrollador.Text = "Modo Desarrollador"
        Me.btnDesarrollador.UseVisualStyleBackColor = True
        '
        'btnDidactico
        '
        Me.btnDidactico.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDidactico.Location = New System.Drawing.Point(242, 0)
        Me.btnDidactico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDidactico.Name = "btnDidactico"
        Me.btnDidactico.Size = New System.Drawing.Size(242, 261)
        Me.btnDidactico.TabIndex = 1
        Me.btnDidactico.Text = "Modo Didáctico"
        Me.btnDidactico.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.btnDidactico)
        Me.Controls.Add(Me.btnDesarrollador)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDesarrollador As System.Windows.Forms.Button
    Friend WithEvents btnDidactico As System.Windows.Forms.Button

End Class
