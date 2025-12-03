<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        RegistroDeUsuariosToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {UsuariosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistroDeUsuariosToolStripMenuItem})
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(64, 20)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' RegistroDeUsuariosToolStripMenuItem
        ' 
        RegistroDeUsuariosToolStripMenuItem.Name = "RegistroDeUsuariosToolStripMenuItem"
        RegistroDeUsuariosToolStripMenuItem.Size = New Size(181, 22)
        RegistroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios"
        ' 
        ' Form_Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form_Admin"
        Text = "Administración"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeUsuariosToolStripMenuItem As ToolStripMenuItem
End Class
