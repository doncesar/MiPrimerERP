Imports System.Security.Cryptography
Imports System.Text


Public Class Seguridad
    ' Genera un hash SHA256 a partir de un string
    Public Shared Function GenerarHash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

End Class
