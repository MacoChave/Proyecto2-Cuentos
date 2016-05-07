Public Class Inicio

    Private Sub btnDesarrollador_Click(sender As Object, e As EventArgs) Handles btnDesarrollador.Click
        Desarrollador.Show()
    End Sub

    Private Sub btnDidactico_Click(sender As Object, e As EventArgs) Handles btnDidactico.Click
        If (ListaCuento.listaCuento.Count > 0) Then
            Didactico.Show()
        Else
            'Didactico.Show()
            MessageBox.Show("Aún no hay cuentos :(", "Error")
        End If
    End Sub
End Class
