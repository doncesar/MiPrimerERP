Imports Microsoft.Data.SqlClient

Public Class Form_Registro

    Dim conexion As New SqlConnection("Server=.\SQLEXPRESS;Database=MiPrimerERP;Integrated Security=True;TrustServerCertificate=True")

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Try
            conexion.Open()

            ' Capturar datos del formulario
            Dim usuario As String = txt_Usuario.Text
            Dim passwordHash As String = Seguridad.GenerarHash(txt_Password.Text) ' Usamos la función de la clase Seguridad
            Dim nombre As String = txt_Nombre.Text
            Dim email As String = txt_Email.Text
            Dim rol As String = cmb_Rol.SelectedItem.ToString()

            ' Insertar en la tabla Usuarios
            Dim cmd As New SqlCommand("INSERT INTO Usuarios (Usuario, PasswordHash, Nombre, Email, Rol) VALUES (@usuario, @pass, @nombre, @email, @rol)", conexion)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@pass", passwordHash)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@rol", rol)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub
End Class