Public Class Inicio

    Private Sub btnDesarrollador_Click(sender As Object, e As EventArgs) Handles btnDesarrollador.Click
        Me.Hide()
        Desarrollador.Show()
    End Sub

    Private Sub btnDidactico_Click(sender As Object, e As EventArgs) Handles btnDidactico.Click
        'If (ListaToken.listaToken.Count > 0) Then
        '    Me.Hide()

        'Else
        '    MessageBox.Show("No hay cuentos", "Error")
        'End If
        Me.Hide()
        Didactico.Show()

    End Sub
End Class
