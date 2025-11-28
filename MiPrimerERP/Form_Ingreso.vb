Imports System.Data.SqlClient

Public Class Form_Ingreso

    ' Cadena de conexión (ajústala según tu servidor y base de datos)
    Dim conexion As New SqlConnection("Server=TU_SERVIDOR;Database=InventarioDB;Integrated Security=True")

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Try
            conexion.Open()

            ' Consulta para validar usuario y contraseña
            Dim passwordHash As String = Seguridad.GenerarHash(txt_Password.Text)

            Dim cmd As New SqlCommand("SELECT Rol FROM Usuarios WHERE Usuario=@usuario AND PasswordHash=@pass", conexion)
            cmd.Parameters.AddWithValue("@usuario", txt_Usuario.Text)
            cmd.Parameters.AddWithValue("@pass", passwordHash)

            Dim rol As Object = cmd.ExecuteScalar()

            If rol IsNot Nothing Then
                MessageBox.Show("Login correcto. Rol: " & rol.ToString(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Redirigir según rol
                Select Case rol.ToString()
                    Case "Administrador"
                        Dim frmAdmin As New Form_Admin()
                        frmAdmin.Show()
                    Case "Operador"
                        Dim frmOperador As New Form_Operador()
                        frmOperador.Show()
                    Case "Consulta"
                        Dim frmConsulta As New Form_Consulta()
                        frmConsulta.Show()
                End Select

                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub
End Class
