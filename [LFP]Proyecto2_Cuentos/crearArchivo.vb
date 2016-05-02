Imports System.IO
Imports System.Text

Class crearArchivo

    Public Sub tokenHtml()
        Dim html As String
        html = "<!DOCTYPE html>" & vbCrLf
        html += "<html lang=" & Chr(34) & "es" & Chr(34) & ">" & vbCrLf
        html += "<head>" & vbCrLf
        html += "<meta charset=" & Chr(34) & "UTF-8" & Chr(34) & ">" & vbCrLf
        html += "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "style.css" & Chr(34) & ">" & vbCrLf
        html += "<title>Tabla de Token</title>" & vbCrLf
        html += "</head>" & vbCrLf
        html += "<body>" & vbCrLf
        html += "<header><div class = " & Chr(34) & "menu" & Chr(34) & ">" & vbCrLf
        html += "<ul><li><a href=" & Chr(34) & "#" & Chr(34) & ">Lista Token</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "error.html" & Chr(34) & ">Lista Error</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "#" & Chr(34) & ">Tabla Simbolos</a></li></ul>" & vbCrLf
        html += "</div></header>"
        html += "<h1>Token Reconocidos</h1>" & vbCrLf
        html += "<table>" & vbCrLf
        html += "<tr>" & vbCrLf
        html += "<th>No</th>" & vbCrLf
        html += "<th>Lexema</th>" & vbCrLf
        html += "<th>Token</th>" & vbCrLf
        html += "<th>Posición</th>" & vbCrLf
        html += "</tr>" & vbCrLf

        For t As Integer = 0 To ListaToken.listaToken.Count - 1 Step 1
            html += "<tr><td>" & t + 1 & "</td>" & vbCrLf
            html += "<td>" & ListaToken.listaToken.Item(t)._lexema & "</td>" & vbCrLf
            html += "<td>" & ListaToken.listaToken.Item(t)._token & "</td>" & vbCrLf
            html += "<td> Fila " & ListaToken.listaToken.Item(t)._fila & ", columna " & ListaToken.listaToken.Item(t)._columna & "</td>" & vbCrLf
            html += "</tr>" & vbCrLf
        Next

        html += "</table>" & vbCrLf
        html += "<footer><p><b>Lenguajes Formales y de Programación</b></p>" & vbCrLf
        html += "<p>Marco Antonio Chávez Fuentes</p>" & vbCrLf
        html += "<p>2010-20831</p></footer>" & vbCrLf
        html += "</body>" & vbCrLf
        html += "</html>"

        Dim path As String = "C:\Users\Public\Documents\token.html"
        'Dim path As String = "C:\Users\u\Desktop\token.html"

        'CREAR O SOBREESCRIBIR EL ARCHIVO
        Dim fs As FileStream = File.Create(path)

        'AGREGAR EL TEXTO A EL ARCHIVO
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(html)
        fs.Write(info, 0, info.Length)
        fs.Close()
        MessageBox.Show("Se creó la tabla de token encontrados en " & path, "Exito")
    End Sub

    Public Sub errorHtml()
        Dim html As String
        html = "<!DOCTYPE html>" & vbCrLf
        html += "<html lang=" & Chr(34) & "es" & Chr(34) & ">" & vbCrLf
        html += "<head>" & vbCrLf
        html += "<meta charset=" & Chr(34) & "UTF-8" & Chr(34) & ">" & vbCrLf
        html += "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "style.css" & Chr(34) & ">" & vbCrLf
        html += "<title>Tabla de Errores</title>" & vbCrLf
        html += "</head>" & vbCrLf
        html += "<body>" & vbCrLf
        html += "<header><div class = " & Chr(34) & "menu" & Chr(34) & ">" & vbCrLf
        html += "<ul><li><a href=" & Chr(34) & "token.html" & Chr(34) & ">Lista Token</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "#" & Chr(34) & ">Lista Error</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "#" & Chr(34) & ">Tabla Simbolos</a></li></ul>" & vbCrLf
        html += "</div></header>"
        html += "<h1>Token Reconocidos</h1>" & vbCrLf

        If (ListaError.listaError.Count > 0) Then
            html += "<table>" & vbCrLf
            html += "<tr>" & vbCrLf
            html += "<th>No</th>" & vbCrLf
            html += "<th>Lexema</th>" & vbCrLf
            html += "<th>Posición</th>" & vbCrLf
            html += "<th>Error</th>" & vbCrLf
            html += "</tr>" & vbCrLf

            For t As Integer = 0 To ListaError.listaError.Count - 1 Step 1
                html += "<tr><td>" & t + 1 & "</td>" & vbCrLf
                html += "<td>" & ListaError.listaError.Item(t)._lexema & "</td>" & vbCrLf
                html += "<td> Fila " & ListaError.listaError.Item(t)._fila & ", columna " & ListaError.listaError.Item(t)._columna & "</td>" & vbCrLf
                html += "<td>" & ListaError.listaError.Item(t)._descripcion & "</td>" & vbCrLf
                html += "</tr>" & vbCrLf
            Next

            html += "</table>" & vbCrLf

        Else
            html += "</br><p class = exito>¡Genial! No hay errores</p>"
        End If
        
        html += "<footer><p><b>Lenguajes Formales y de Programación</b></p>" & vbCrLf
        html += "<p>Marco Antonio Chávez Fuentes</p>" & vbCrLf
        html += "<p>2010-20831</p></footer>" & vbCrLf
        html += "</body>" & vbCrLf
        html += "</html>"

        Dim path As String = "C:\Users\Public\Documents\error.html"
        'Dim path As String = "C:\Users\u\Desktop\error.html"

        'CREAR O SOBREESCRIBIR EL ARCHIVO
        Dim fs As FileStream = File.Create(path)

        'AGREGAR EL TEXTO A EL ARCHIVO
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(html)
        fs.Write(info, 0, info.Length)
        fs.Close()
        MessageBox.Show("Se creó la tabla de errores encontrados en " & path, "Exito")
    End Sub

End Class
