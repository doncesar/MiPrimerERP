Imports Microsoft.Data.SqlClient

Public Class Form_Registro

    Dim conexion As New SqlConnection("Server=.\SQLEXPRESS;Database=MiPrimerERP;Integrated Security=True;TrustServerCertificate=True")

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Try
            Using conexion As New SqlConnection("Server=.\SQLEXPRESS;Database=MiPrimerERP;Integrated Security=True;TrustServerCertificate=True")
                conexion.Open()

                ' Capturar datos del formulario
                Dim usuario As String = txt_Usuario.Text.Trim()
                Dim passwordHash As String = Seguridad.GenerarHash(txt_Password.Text.Trim())
                Dim nombre As String = txt_Nombre.Text.Trim()
                Dim email As String = txt_Email.Text.Trim()
                Dim rol As String = cmb_Rol.SelectedItem.ToString()

                ' Insertar en la tabla Usuarios
                Dim query As String = "INSERT INTO Usuarios (Usuario, PasswordHash, Nombre, Email, Rol) VALUES (@usuario, @pass, @nombre, @email, @rol)"
                Using cmd As New SqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@usuario", usuario)
                    cmd.Parameters.AddWithValue("@pass", passwordHash)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@rol", rol)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresca la grilla
            CargarUsuarios()

            ' Limpia los campos del formulario
            txt_Usuario.Clear()
            txt_Password.Clear()
            txt_Nombre.Clear()
            txt_Email.Clear()
            cmb_Rol.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Registro_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        Using conexion As New SqlConnection("Server=.\SQLEXPRESS;Database=MiPrimerERP;Integrated Security=True;TrustServerCertificate=True")
            conexion.Open()
            Dim query As String = "SELECT Usuario, Nombre, Email, Rol FROM Usuarios"
            Dim adaptador As New SqlDataAdapter(query, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            DataGridView1.DataSource = tabla
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.ReadOnly = True
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End Using
    End Sub

End Class