Public Class Form_Admin
    Private Sub RegistroDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeUsuariosToolStripMenuItem.Click
        Form_Registro.Show()
    End Sub

    Private Sub Form_Admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class