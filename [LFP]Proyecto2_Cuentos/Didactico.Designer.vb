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
        Me.RchTxtTexto = New System.Windows.Forms.RichTextBox()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.Titulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Imagen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnTexto = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnResaltar = New System.Windows.Forms.Button()
        Me.btnReproducir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Titulo, Me.Imagen})
        Me.ListView.Location = New System.Drawing.Point(12, 12)
        Me.ListView.MultiSelect = False
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(327, 395)
        Me.ListView.TabIndex = 4
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'btnTexto
        '
        Me.btnTexto.Location = New System.Drawing.Point(3, 6)
        Me.btnTexto.Name = "btnTexto"
        Me.btnTexto.Size = New System.Drawing.Size(103, 23)
        Me.btnTexto.TabIndex = 5
        Me.btnTexto.Text = "Mostrar cuento"
        Me.btnTexto.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnResaltar)
        Me.Panel1.Controls.Add(Me.btnReproducir)
        Me.Panel1.Controls.Add(Me.btnTexto)
        Me.Panel1.Location = New System.Drawing.Point(13, 413)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 36)
        Me.Panel1.TabIndex = 6
        '
        'btnResaltar
        '
        Me.btnResaltar.Location = New System.Drawing.Point(221, 6)
        Me.btnResaltar.Name = "btnResaltar"
        Me.btnResaltar.Size = New System.Drawing.Size(103, 23)
        Me.btnResaltar.TabIndex = 5
        Me.btnResaltar.Text = "Resaltar palabras"
        Me.btnResaltar.UseVisualStyleBackColor = True
        '
        'btnReproducir
        '
        Me.btnReproducir.Location = New System.Drawing.Point(112, 6)
        Me.btnReproducir.Name = "btnReproducir"
        Me.btnReproducir.Size = New System.Drawing.Size(103, 23)
        Me.btnReproducir.TabIndex = 5
        Me.btnReproducir.Text = "Reproducir cuento"
        Me.btnReproducir.UseVisualStyleBackColor = True
        '
        'Didactico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.RchTxtTexto)
        Me.Name = "Didactico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Didactico"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RchTxtTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents btnTexto As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnResaltar As System.Windows.Forms.Button
    Friend WithEvents btnReproducir As System.Windows.Forms.Button
    Friend WithEvents Titulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Imagen As System.Windows.Forms.ColumnHeader
End Class
