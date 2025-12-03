Imports System.ComponentModel
Imports Microsoft.Data.SqlClient

Public Class Form_Ingreso

    ' Cadena de conexión (ajústala según tu servidor y base de datos)
    Dim conexion As New SqlConnection("Server=.\SQLEXPRESS;Database=MiPrimerERP;Integrated Security=True;TrustServerCertificate=True")

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
                    Case "Supervisor"
                        Dim frmSupervisor As New Form_Supervisor()
                        frmSupervisor.Show()
                End Select

                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Form_Ingreso_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label_Fecha.Text = FormatDateTime(Today, DateFormat.LongDate)

        Me.Label_Hora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label_Hora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

End Class
