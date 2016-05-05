Public Class Didactico

    Private Sub Didactico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 5 Step 1
            ListView1.Items.Add("E" & i, "Elemento " & i)
        Next
    End Sub

End Class