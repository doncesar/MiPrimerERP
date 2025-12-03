<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registro
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
        GroupBox1 = New GroupBox()
        txt_Usuario = New TextBox()
        txt_Password = New TextBox()
        txt_Nombre = New TextBox()
        txt_Email = New TextBox()
        cmb_Rol = New ComboBox()
        btn_Registrar = New Button()
        btn_Cancelar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_Cancelar)
        GroupBox1.Controls.Add(btn_Registrar)
        GroupBox1.Controls.Add(cmb_Rol)
        GroupBox1.Controls.Add(txt_Email)
        GroupBox1.Controls.Add(txt_Nombre)
        GroupBox1.Controls.Add(txt_Password)
        GroupBox1.Controls.Add(txt_Usuario)
        GroupBox1.Location = New Point(10, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(490, 324)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(85, 22)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(100, 23)
        txt_Usuario.TabIndex = 0
        ' 
        ' txt_Password
        ' 
        txt_Password.Location = New Point(88, 57)
        txt_Password.Name = "txt_Password"
        txt_Password.Size = New Size(100, 23)
        txt_Password.TabIndex = 1
        txt_Password.UseSystemPasswordChar = True
        ' 
        ' txt_Nombre
        ' 
        txt_Nombre.Location = New Point(88, 97)
        txt_Nombre.Name = "txt_Nombre"
        txt_Nombre.Size = New Size(100, 23)
        txt_Nombre.TabIndex = 2
        ' 
        ' txt_Email
        ' 
        txt_Email.Location = New Point(88, 135)
        txt_Email.Name = "txt_Email"
        txt_Email.Size = New Size(100, 23)
        txt_Email.TabIndex = 3
        ' 
        ' cmb_Rol
        ' 
        cmb_Rol.FormattingEnabled = True
        cmb_Rol.Items.AddRange(New Object() {"Administrador", "Operador", "Consulta"})
        cmb_Rol.Location = New Point(90, 171)
        cmb_Rol.Name = "cmb_Rol"
        cmb_Rol.Size = New Size(121, 23)
        cmb_Rol.TabIndex = 4
        ' 
        ' btn_Registrar
        ' 
        btn_Registrar.Location = New Point(39, 212)
        btn_Registrar.Name = "btn_Registrar"
        btn_Registrar.Size = New Size(75, 23)
        btn_Registrar.TabIndex = 5
        btn_Registrar.Text = "REGISTRAR"
        btn_Registrar.UseVisualStyleBackColor = True
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.Location = New Point(137, 213)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(75, 23)
        btn_Cancelar.TabIndex = 6
        btn_Cancelar.Text = "CANCELAR"
        btn_Cancelar.UseVisualStyleBackColor = True
        ' 
        ' Form_Registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "Form_Registro"
        Text = "Form_Registro"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents cmb_Rol As ComboBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents btn_Cancelar As Button
End Class
