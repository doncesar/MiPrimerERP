Imports System.Security.Cryptography
Imports System.Text

Public Class Seguridad
    ' Genera un hash SHA256 a partir de un string
    Public Shared Function GenerarHash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            ' Siempre usar UTF8 para consistencia
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password.Trim())
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)

            ' Convertir a hexadecimal en minúsculas, sin guiones
            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function
End Class